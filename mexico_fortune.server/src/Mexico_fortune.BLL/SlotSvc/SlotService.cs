using Mexico_fortune.BLL.Caching;
using Mexico_fortune.DAL;
using TinyFx;
using TinyFx.Collections;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Mexico_fortune.BLL
{
    public class SlotService : BaseApiGameService
    {
        private Gmf_user_chips_dataMO _userChipsDataMo = new();
        private Gmf_user_slotMO _slotMo = new();
        private Gmf_return_poolMO _poolReturnMo = new();
        private readonly All_pool_change_detailMO _poolChangeMo = new();

        public async Task<SlotDto> Slot(SlotIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var appToken = GetLoginTokenDo(ipo.UserId);
            var context = new SlotContext(ipo, appToken);
            context.UserDataDo = await (new UserDataDCache(context.UserId).GetUserChipsDataDo(context.ChipsId));
            if (context.UserDataDo.UserStatus != SlotUserStatus.Normal)
                throw new CustomException(CommonCodes.UserStatusError, $"SlotService用户状态异常。userId: {context.UserId}");
            context.IsFreeSpin = context.UserDataDo.FreeSpinNum > 0;

            var userCache = new UserDataDCache(ipo.UserId);
            var lockKey = $"{appToken.AppId}:{ipo.UserId}";
            using (var redlock = await RedisUtil.LockAsync(lockKey, CommonCodes.LockTime))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"{lockKey}:请求分布式锁失败!");
                }
                var slotId = context.SlotId = SnowflakeIdUtil.NextId();
                await ExecuteContext(context);
                long balance = 0;
                // 先插入数据
                await SlotUtil.AddSlotDetail(context, slotId, null);
                await _userChipsDataMo.PutSlotIDByPKAsync(context.UserId, context.ChipsId, slotId, null);

                var tm = new TransactionManager();
                try
                {
                    if (!context.IsFreeSpin)
                    {
                        // 调用第三方
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, slotId.ToString()
                            , context.BetAmount, context.TotalAmount)).Balance;
                        context.IsChangeBalance = true;
                        // 更新奖池
                        await PutPool(context, context.PartAmount.PartPoolAmount, tm);
                    }
                    else
                    {
                        // 调用第三方
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, slotId.ToString()
                            , 0, context.TotalAmount)).Balance;
                        context.IsChangeBalance = true;
                    }
                    await _slotMo.PutStatusByPKAsync(slotId, (int)OrderStatus.Success, tm);
                    await SlotUtil.UpdateUserData(context, slotId, tm);
                    // 更新缓存
                    await userCache.SetUserChipsDataDo(context.ChipsId, context.UserDataDo);

                    tm.Commit();
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
                    await _slotMo.PutStatusByPKAsync(slotId, (int)status, tm);
                    await userCache.KeyDeleteAsync();
                    throw;
                }
                return await BuildDto(context, balance);
            }
        }
        private async Task PutPool(SlotContext context, long changeAmount, TransactionManager tm)
        {
            var beforeAmount = await _poolReturnMo.GetValueByPKAsync(context.OperatorId, context.CurrencyId, tm);
            await _poolReturnMo.PutByPKAsync(context.OperatorId, context.CurrencyId, $"Value=Value+{changeAmount}", tm);
            var afterAmount = await _poolReturnMo.GetValueByPKAsync(context.OperatorId, context.CurrencyId, tm);
            await _poolChangeMo.AddAsync(new All_pool_change_detailEO
            {
                ChangeID = SnowflakeIdUtil.NextId(),
                AppID = context.AppId,
                OperatorID = context.OperatorId,
                CurrencyID = context.CurrencyId,
                BetID = context.SlotId,
                UserID = context.UserId,
                BeforeAmount = beforeAmount,
                ChangeAmount = changeAmount,
                AfterAmount = afterAmount,
                RecDate = DateTime.UtcNow,
            }, tm);

        }
        private async Task ExecuteContext(SlotContext context)
        {
            await new SlotInitProcess().Execute(context);
            await new SlotBingoProcess().Execute(context);
            await new SlotBonusProcess().Execute(context);
            await new SlotBaseProcess().Execute(context);
            await new SlotQueryProcess().Execute(context);
        }

        private async Task<SlotDto> BuildDto(SlotContext context, long balance)
        {
            var ret = new SlotDto();
            ret.SlotId = context.SlotId.ToString();
            ret.ItemId = context.QueryData.ItemId.ToString();
            ret.PlayerInfo.Balance = balance.AToM(context.CurrencyId);
            //
            ret.ResultInfo.SlotEles = ArrayUtil.TwoDToListRows(context.QueryData.SlotEles);
            ret.ResultInfo.TotalReward = context.QueryData.TotalReward;
            ret.ResultInfo.TotalMulti = context.BaseData.Multip / 10;
            ret.ResultInfo.RewardDetails = context.QueryData.RewardDetails;
            ret.ResultInfo.FreeSpinCount = context.UserDataDo.FreeSpinNum;
            ret.ResultInfo.FreeSpinTotalReward = context.UserDataDo.FreeSpinAmount.AToM(context.CurrencyId);
            ret.ResultInfo.AddFreeSpinCountList = context.BonusData.NewRetriggerNum == 0
                ? new List<int>()
                : new List<int> { context.BonusData.NewRetriggerNum };
            //
            ret.LottoryResultInfo.IsTriggerJpReward = context.BingoData.IsWin;
            ret.LottoryResultInfo.JpReward = context.BingoData.WinAmount.AToM(context.CurrencyId);
            ret.LottoryResultInfo.JpRewardIndex = (int)context.BingoData.JPPoolType;
            ret.LottoryResultInfo.LottoryEle = ArrayUtil.TwoDToListRows(context.UserDataDo.BingoPanelNumTwoD);
            ret.LottoryResultInfo.NewEle = context.BingoData.NewNums;
            return ret;
        }
    }
}

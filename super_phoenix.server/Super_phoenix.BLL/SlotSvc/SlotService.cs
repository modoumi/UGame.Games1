using Super_phoenix.DAL;
using TinyFx;
using TinyFx.Data;
using TinyFx.SnowflakeId;
using TinyFx.Extensions.StackExchangeRedis;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Enum;
using Xxyy.GameEAPI.Core;
using Xxyy.GameEAPI.Services;

namespace Super_phoenix.BLL
{
    public class SlotService : BaseApiGameService
    {
        private readonly Gsp_user_dataMO _userDataMO = new();
        private readonly Gsp_user_extMO _extMO = new();
        private readonly Gsp_bet_detailMO _betDetailMo = new();
        private readonly Gsp_pool_returnMO _poolReturnMo = new();
        public async Task<Super_phoenixSlotDto> Slot(Super_phoenixSlotIpo ipo)
        {
            var appToken = GetLoginTokenDo(ipo.UserId);
            await CheckIdentityAndMock(ipo.UserId);

            var context = new SlotContext(ipo, appToken);
        /*    var lockKey = $"{appToken.AppId}:{ipo.UserId}";
            using (var redlock = await RedisUtil.LockAsync(lockKey, CommonCodes.LockTime))
            {
                if (!redlock.IsLocked)
                {
                    redlock.Release();
                    throw new CustomException(CommonCodes.UserConcurrent, $"{lockKey}:请求分布式锁失败!");
                }*/
                //算法逻辑
                await ExecuteContext(context);
                var betId = context.BetId = SnowflakeIdUtil.NextId();
                long balance = 0;
                //先插入数据
                await SuperUtil.AddBetDetail(context, betId, null);

                var tm = new TransactionManager();
                try
                {
                    if (!context.IsFreeSpin)
                    {
                        balance = await GameEAPIUtil.GetBalance(context.UserId, context.AppId);
                        if (balance < context.Config_Chips.BetAmount)
                        {
                            throw new CustomException(CommonCodes.RS_NOT_ENOUGH_MONEY, "余额不足");
                        }
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                                 , context.Config_Chips.BetAmount, context.RealWinAmount)).Balance;
                        context.IsChangeBalance = true;
                        //更新基础奖池
                        await _poolReturnMo.PutByPKAsync(context.OperatorId, context.CurrencyId, $"PoolVal=PoolVal+{context.PartAmount.PartBaseAmount}", tm);
                    }
                    else
                    {
                        balance = (await GameEAPIUtil.BetWin(context.UserId, context.AppId, betId.ToString()
                                 , 0, context.RealWinAmount)).Balance;
                        context.IsChangeBalance = true;
                    }
                    //更新下注表
                    await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)OrderStatus.Success, tm);
                    //更新用户
                    await _userDataMO.PutAsync(context.UserData, tm);
                    await _extMO.PutByPKAsync(context.UserId,
                        $"UserStatus={(int)GameUserStatus.Normal},MiniGameTotalVal={context.UserExt.MiniGameTotalVal}", tm);
                    tm.Commit();
                }
                catch (Exception ex)
                {
                    tm.Rollback();
                    await SlotRollback(context, betId, tm);
                    throw;
                }
                return await BuildDto(context, balance);
           // }
        }

        private async Task SlotRollback(SlotContext context, long betId, TransactionManager tm)
        {
            var status = context.IsChangeBalance ? OrderStatus.Exception : OrderStatus.Fail;
            await _betDetailMo.PutOrderStatusByPKAsync(betId, (int)status, tm);
        }

        private async Task ExecuteContext(SlotContext context)
        {
            await new SlotInitProcess().Execute(context);
            await new SlotProcess().Execute(context);

        }

        private async Task<Super_phoenixSlotDto> BuildDto(SlotContext context, long balance)
        {
            var ret = new Super_phoenixSlotDto();
            ret.PlayerInfo.Balance = balance.AToM(context.CurrencyId);

            ret.ResultInfo.TotalReward = context.WinAmount.AToM(context.CurrencyId) * context.IsWin;
            ret.ResultInfo.TotalMulti = context.TotalMultip * context.IsWin;
            ret.ResultInfo.FreeSpinCount = context.UserData.FreeSpinCount;
            ret.ResultInfo.FreeSpinTotalReward = context.UserData.FreeSpinTotalReward.AToM(context.CurrencyId);
            ret.ResultInfo.RewardDetails = context.RewardDetails;
            ret.ResultInfo.SlotEles = context.SlotEleArray;
            return ret;
        }

    }
}
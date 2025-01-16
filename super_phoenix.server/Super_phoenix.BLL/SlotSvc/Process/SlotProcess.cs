using Super_phoenix.BLL.Caching;
using Super_phoenix.BLL.Core;
using Super_phoenix.DAL;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Common.Services;
using Xxyy.GameEAPI.Core;
using static Super_phoenix.BLL.SuperUtil;

namespace Super_phoenix.BLL
{
    internal class SlotProcess : SlotProcessBase
    {
        public override async Task Execute(SlotContext context)
        {
            UserService _userSvc = new(context.UserId);
            if (await _userSvc.GetBonus() < 50)
            {
                context.UserExt.MiniGameTotalVal += context.PartAmount.PartMiniGameTotalVal;
            }
            //随机列权重
            context.ItemType = GameItemType.Main;
            if (context.IsFreeSpin)
            {
                context.ItemType = (GameItemType)GetWeightByAvg();
                context.UserData.FreeSpinCount--;
            }
            context.TriggerMiniGame = 0;

            //step1 触发小游戏条件,根据累计值判断
            if (context.UserExt.MiniGameTotalVal >= context.TriggerFreeSpinVal && !context.IsFreeSpin)
            {
                context.UserExt.MiniGameTotalVal -= context.TriggerFreeSpinVal;
                var odds = (decimal)context.TriggerFreeSpinVal / context.TriggerFreeSpinVal_Denominator;
                var yes = RandomUtil.IsOdds(odds, 100);
                context.TriggerFreeSpinOdds = yes ? 1 : 2;
                if (yes)
                {
                    context.TriggerMiniGame = 1;
                    context.UserData.FreeSpinCount = context.Config.FreeSpinCount;
                    context.UserData.FreeSpinTotalReward = 0;
                }
            }
            //step1 取随机图标,分配到25条线,取中奖总倍数
            context.WeightColumnList = MemoryUtil.GetBuildWeight(context.ItemType).ToArray();
            await GetIconByWeight(context);
        }

        public async Task GetIconByWeight(SlotContext context)
        {
            //构建3*5的table
            var arrays = BuildTable(context);
            //25条线上对应的元素id,icon
            List<List<int>> line_weightList = BuildIconInLine(context, arrays.ToArray());
            List<int> totalMultip = new();
            int lineNo = 1;
            foreach (var ItemIdList in line_weightList)
            {
                //ItemIdList是线上的元素id
                List<int> result = new();
                for (int i = 0; i < ItemIdList.Count; i++)
                {
                    var _itemId = ItemIdList[i];
                    if (i == 0)
                    {
                        result.Add(_itemId);
                    }
                    else
                    {
                        if (_itemId == WILD)
                        {
                            result.Add(_itemId);
                        }
                        else
                        {
                            if (result.First() == WILD && _itemId != SCATTER)
                            {
                                result[0] = _itemId;
                                result.Add(_itemId);
                            }
                            else if (result.Contains(_itemId))
                            {
                                result.Add(_itemId);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                //中奖
                if (result.Count >= 3)
                {
                    var _multipCount = result.Count;
                    Gsp_config_multipEO? multipEo = null;
                    int wildCount = result.Count(x => x == WILD);
                    if (wildCount >= 3)
                    {
                        _multipCount = wildCount;
                        multipEo = MemoryUtil.GetMaxMultip();
                    }
                    else
                    {
                        var itemId = result.FirstOrDefault();
                        multipEo = MemoryUtil.GetMultip(itemId);
                    }
                    if (multipEo != null)
                    {
                        int _multip = 0;
                        switch (_multipCount)
                        {
                            case 3:
                                _multip = multipEo.Multip3;
                                break;
                            case 4:
                                _multip = multipEo.Multip4;
                                break;
                            case 5:
                                _multip = multipEo.Multip5;
                                break;
                            default:
                                break;
                        }
                        RewardDetail rewardDetail = new()
                        {
                            Line = lineNo,
                            Reward = (context.Config_Chips.SingleAmount * _multip).AToM(context.CurrencyId),
                            SameUnitCount = _multipCount,
                            Multi = _multip,
                        };
                        context.RewardDetails.Add(rewardDetail);
                        totalMultip.Add(_multip);
                        if (context.IsFreeSpin)
                        {
                            context.UserData.FreeSpinTotalReward += _multip * context.Config_Chips.SingleAmount;
                        }
                    }
                }
                lineNo++;
            }
            context.HistoryMultip = string.Join("|", totalMultip);
            context.TotalMultip = totalMultip.Sum();
            context.WinAmount = context.TotalMultip * context.Config_Chips.SingleAmount;
            //未中奖1,3轴替换2个scatter
            if (context.TotalMultip == 0 && context.TriggerFreeSpinOdds == 2)
            {
                arrays[GetWeightByAvg()][0] = SCATTER;
                var sss = new Random().Next(10);
                if (sss > 4)
                {
                    arrays[GetWeightByAvg()][2] = SCATTER;
                }
            }
            context.SlotEleArray = BuildTableByY(arrays);
            var text = string.Empty;
            for (int i = 0; i < arrays.Count; i++)
            {
                text += string.Join("|", arrays[i]) + ",";
            }
            context.HistoryLine = text.TrimEnd(',');
            //查询奖池是否足够
            var flag = await CheckPoolReturn(context, context.WinAmount);
            context.IsWin = flag ? 1 : 0;
            //奖池不足
            if (!flag)
            {
                context.RewardDetails.Clear();
                context.SlotEleArray = BuildTablePoolNo(context);
                context.UserData.FreeSpinTotalReward = 0;
            }
            //总倍数BIG触发跑马灯
            if (context.TotalMultip >= context.Config.BIG && flag)
            {
                Gsp_user_lampMO _lampEO = new();
                var lampEo = new Gsp_user_lampEO
                {
                    OperatorID = context.OperatorId,
                    CurrencyID = context.CurrencyId,
                    PlayerName = await GameEAPIUtil.GetNickName(context.UserId),
                    Multip = context.TotalMultip,
                    Reward = context.RealWinAmount,
                    RecDate = DateTime.UtcNow,
                };
                MemoryUtil.PutLampList(lampEo, context.OperatorId, context.CurrencyId);
                await _lampEO.AddAsync(lampEo);
            }
        }
    }
}
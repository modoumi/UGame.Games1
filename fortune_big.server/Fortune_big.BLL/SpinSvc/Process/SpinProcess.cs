using Fortune_big.BLL.Caching;
using MathNet.Numerics.Random;
using TinyFx;
using TinyFx.Logging;
using TinyFx.Randoms;
using TinyFx.Text;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;
using static Fortune_big.BLL.Fortune_BigUtil;

namespace Fortune_big.BLL
{
    internal class SpinProcess : BetProcessBase
    {
        public override async Task Execute(SpinContext context)
        {
            await Spin_Main(context);
        }

        public async Task Spin_Free(SpinContext context, int num)
        {
            var tableList = BuildTableList_Free(context);
            var timestamp = GameEAPIUtil.DataTimeUTCToTimestamp(DateTime.UtcNow, false);
            var _free = new GameInfo
            {
                Bet = 0,
                Date = timestamp,
                SlotEleList = tableList,
                Transactionld =ObjectId.NewId(),
                N = num,
            };
            var hitLineDic = MatchLine(context, tableList);
            foreach (var lineNo in hitLineDic.Keys)
            {
                var SymbolIdList = hitLineDic[lineNo];
                //ItemIdList是线上的元素id
                List<int> symbolIdResult = new();
                //ItemIdList中奖线中的itemId
                for (int i = 0; i < SymbolIdList.Count; i++)
                {
                    var _symbolId = SymbolIdList[i];
                    if (i == 0)
                    {
                        symbolIdResult.Add(_symbolId);
                    }
                    else
                    {
                        if (_symbolId == WILD && !(_symbolId == FREE || _symbolId == RESPIN || _symbolId == JJ))
                        {
                            symbolIdResult.Add(_symbolId);
                        }
                        else
                        {
                            if (symbolIdResult.Count > 0 && symbolIdResult.First() == WILD)
                            {
                                symbolIdResult[0] = _symbolId;
                                symbolIdResult.Add(_symbolId);
                            }
                            else if (symbolIdResult.Contains(_symbolId))
                            {
                                symbolIdResult.Add(_symbolId);
                            }
                            else { break; }
                        }
                    }
                }
                var _sameCount = symbolIdResult.Count;

                //中奖
                if (_sameCount >= 3)
                {
                    var symbolId = symbolIdResult.FirstOrDefault();
                    var _IndexHaveList = new int[5];
                    for (int i = 0; i < symbolIdResult.Count; i++)
                    {
                        int id = symbolIdResult[i];
                        if ((id == symbolId && !(symbolId == FREE || symbolId == RESPIN || symbolId == JJ)) || id == WILD)
                            _IndexHaveList[i] = 1;
                        else _IndexHaveList[i] = 0;
                    }
                    var multipEo = MemoryUtil.GetSymbolById(symbolId);
                    LogUtil.Debug($"中奖-----symbolId:{symbolId}, itemEo:{SerializerUtil.SerializeJsonNet(multipEo)}");
                    if (multipEo != null)
                    {
                        int _singleMultiple = multipEo.SymbolMultiple3;
                        if (_sameCount == 4)
                        {
                            _singleMultiple = multipEo.SymbolMultiple4;
                        }
                        else if (_sameCount == 5)
                        {
                            _singleMultiple = multipEo.SymbolMultiple5;
                        }
                        RewardDetail rewardDetail = new()
                        {
                            LineId = lineNo,
                            Reward = _singleMultiple * context.Chips.SingleAmount.AToM(context.CurrencyId),
                            SameCount = _sameCount,
                            SingleMultiple = _singleMultiple,
                            IndexHaveList = _IndexHaveList.ToList()
                        };
                        _free.RewardDetailList.Add(rewardDetail);
                        _free.TotalMultiple += _singleMultiple;
                    }
                }
            }
            var _reward = (long)(_free.TotalMultiple * context.Chips.SingleAmount);
            var sm_flag = await CheckPoolReturn(context, _reward);
            if (sm_flag)
            {
                _free.TotalReward = _reward.AToM(context.CurrencyId);
                context.SMMultip += _free.TotalMultiple;
                context.SMAmount += _reward;
            }
            //奖池不足
            else
            {
                _free.RewardDetailList.Clear();
                _free.TotalMultiple = 0;
                _free.SlotEleList = BuildTablePoolNo(context);
            }
            _free.Balance = (context.UserExt.Balance + context.RealWinAmount - context.Chips.BetAmount).AToM(context.CurrencyId);
            context.FreeSpinList.Add(_free);
        }
        public async Task Spin_Re(SpinContext context, int num)
        {
            var tableList = GetIconBySpecialMode(context);
            var timestamp = GameEAPIUtil.DataTimeUTCToTimestamp(DateTime.UtcNow, false);
            var _respin = new GameInfo
            {
                Bet = 0,
                Balance = 0,
                Date = timestamp,
                SlotEleList = tableList,
                Transactionld = ObjectId.NewId(),
                N = num,
            };
            var t_list = tableList.SelectMany(list => list);
            var tCount = t_list.Count(x => x > TICON);
            List<float> _reSpinMultip = new();
            List<long> _respinWin = new();
            List<RewardDetail> _bonusRewardDetail = new();
            List<int> ItemIdList = new();
            if (tCount >= SAME)//中奖
            {
                foreach (var itemId in t_list)
                {
                    if (itemId > TICON)
                    {
                        var tEo = MemoryUtil.GetWeightList_t_ByID(itemId);
                        var bWin = (long)(context.Chips.BetAmount * tEo.Multip);

                        _reSpinMultip.Add(tEo.Multip);
                        _respinWin.Add(bWin);
                        ItemIdList.Add(itemId);
                    }
                }
                var flag = await CheckPoolReturn(context, _respinWin.Sum());
                int _isWin = flag ? 1 : 0;
                context.IsWin += _isWin;

                if (flag)
                {
                    RewardDetail rewardDetail = new()
                    {
                        LineId = -1,
                        Reward = _respinWin.Sum().AToM(context.CurrencyId),
                        SameCount = tCount,
                        SingleMultiple = _reSpinMultip.Sum(),
                        IndexHaveList = new(),
                    };
                    _respin.RewardDetailList.Add(rewardDetail);
                    _respin.TotalMultiple = _reSpinMultip.Sum();
                    _respin.TotalReward = _respinWin.Sum().AToM(context.CurrencyId);
                    context.SMAmount += _respinWin.Sum();
                    context.SMMultip += _reSpinMultip.Sum();
                }
                else
                {
                    _respin.SlotEleList = BuildTablePoolNo_Respin(context);
                    _reSpinMultip.Clear();
                    _respinWin.Clear();
                    Console.Write($"respin 奖池不足:{SerializerUtil.SerializeJsonNet(_respin.SlotEleList)}");
                }
            }

            var dateStamp = GameEAPIUtil.DataTimeUTCToTimestamp(DateTime.UtcNow, false);

            context.IsWin = context.IsWin >= 1 ? 1 : 0;
            context.RespinList.Add(_respin);
            _respin.Balance = (context.UserExt.Balance + context.RealWinAmount - context.Chips.BetAmount).AToM(context.CurrencyId);
        }

        public List<List<int>> BuildTablePoolNo_Respin(SpinContext context)
        {
            int[,] matrix = new int[5, 3];
            Random random = new Random();
            int minValue = 101;
            int maxValue = 109;

            int nonZeroCount = 0;

            // Count the number of non-zero elements in the matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        nonZeroCount++;
                    }
                }
            }

            int targetNonZeroCount = random.Next(2, 8);
            int remainingNonZeroCount = targetNonZeroCount - nonZeroCount;

            if (remainingNonZeroCount > 0)
            {
                while (remainingNonZeroCount > 0)
                {
                    int i = random.Next(matrix.GetLength(0));
                    int j = random.Next(matrix.GetLength(1));

                    if (matrix[i, j] == 0)
                    {
                        int randomNumber = random.Next(minValue, maxValue + 1);
                        matrix[i, j] = randomNumber;
                        remainingNonZeroCount--;
                    }
                }
            }
            List<List<int>> matrixList = Enumerable.Range(0, matrix.GetLength(0))
    .Select(i => Enumerable.Range(0, matrix.GetLength(1))
        .Select(j => matrix[i, j])
        .ToList())
    .ToList();
            return matrixList;
        }

        /// <summary>
        /// 特殊模式按权重取图标
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> GetIconBySpecialMode(SpinContext context)
        {
            var _ratio = MemoryUtil.GetTagByAmount(context.Chips.BetAmount).SpecialModeRatio;

            List<List<int>> tableList = new();
            List<int> y1 = new();
            List<int> y2 = new();
            List<int> y3 = new();
            List<int> y4 = new();
            List<int> y5 = new();
            Random_SM(_ratio, y1);
            Random_SM(_ratio, y2);
            Random_SM(_ratio, y3);
            Random_SM(_ratio, y4);
            Random_SM(_ratio, y5);

            tableList.Add(y1);
            tableList.Add(y2);
            tableList.Add(y3);
            tableList.Add(y4);
            tableList.Add(y5);
            return tableList;
        }

        private static void Random_SM(double _ratio, List<int> column)
        {
            for (int i = 0; i < 3; i++)
            {
                if (new MersenneTwister().NextDouble() < _ratio)
                {
                    var smId = GetTMultip_SM();
                    column.Add(smId);
                }
                else
                {
                    column.Add(0);
                }
            }
        }
        public async Task Settle_Main(List<List<int>> tableList, SpinContext context)
        {
            var t_list = tableList.SelectMany(list => list);
            var tCount = t_list.Count(x => x > TICON);
            List<float> _bonusMultip = new();
            List<long> _bonusWin = new();
            List<int> ItemIdList = new();
            if (tCount >= SAME)//中奖
            {
                foreach (var itemId in t_list)
                {
                    if (itemId > TICON)
                    {
                        var tEo = MemoryUtil.GetWeightList_t_ByID(itemId);
                        var bWin = (long)(context.Chips.BetAmount * tEo.Multip);

                        _bonusMultip.Add(tEo.Multip);
                        _bonusWin.Add(bWin);
                        ItemIdList.Add(itemId);
                    }
                }

                RewardDetail rewardDetail = new()
                {
                    LineId = -1,
                    Reward = _bonusWin.Sum().AToM(context.CurrencyId),
                    SameCount = tCount,
                    SingleMultiple = _bonusMultip.Sum(),
                };
                context.WinAmount += _bonusWin.Sum();
                context.TotalMultip += _bonusMultip.Sum();
                context.RewardDetailList.Add(rewardDetail);
            }
        }
        public async Task Spin_Main(SpinContext context)
        {
            var tableList = BuildTableList_Main(context);

            if (context.TriggerFreeSpin == 0 && context.TriggerRespin == 0)
            {
                if (tableList[0].Contains(FREE) && tableList[2].Contains(FREE) && tableList[4].Contains(FREE))
                {
                    context.TriggerFreeSpin = context.Config.FreeSpinNum;
                    context.TriggerSE = 0;
                }

                else if (tableList[0].Contains(RESPIN) && tableList[2].Contains(RESPIN) && tableList[4].Contains(RESPIN))
                {
                    context.TriggerRespin = context.Config.RespinNum;
                    context.TriggerSE = 0;
                }
            }
            var hitLineDic = MatchLine(context, tableList);
            List<int> totalMultip = new();
            foreach (var lineNo in hitLineDic.Keys)
            {
                var SymbolIdList = hitLineDic[lineNo];

                //ItemIdList是线上的元素id
                List<int> symbolIdResult = new();

                int firstEle = SymbolIdList.First();
                if (firstEle == FREE || firstEle == RESPIN || firstEle == JJ)
                    continue;

                for (int i = 0; i < SymbolIdList.Count; i++)//ItemIdList中奖线中的itemId
                {
                    var _symbolId = SymbolIdList[i];

                    if (i == 0)
                    {
                        symbolIdResult.Add(_symbolId);
                    }
                    else
                    {
                        if (_symbolId == WILD)
                        {
                            symbolIdResult.Add(_symbolId);
                        }
                        else
                        {
                            if (symbolIdResult.Count > 0 && symbolIdResult.First() == WILD)
                            {
                                symbolIdResult[0] = _symbolId;
                                symbolIdResult.Add(_symbolId);
                            }
                            else if (symbolIdResult.Contains(_symbolId)) { symbolIdResult.Add(_symbolId); }
                            else { break; }
                        }
                    }
                }
                var _sameCount = symbolIdResult.Count;

                //中奖
                if (_sameCount >= 3)
                {
                    var symbolId = symbolIdResult.FirstOrDefault();
                    var _IndexHaveList = new int[5];
                    for (int i = 0; i < _sameCount; i++)
                    {
                        int id = symbolIdResult[i];
                        if ((id == symbolId && !(symbolId == FREE || symbolId == RESPIN || symbolId == JJ)) || id == WILD)
                            _IndexHaveList[i] = 1;
                        else _IndexHaveList[i] = 0;
                    }

                    var multipEo = MemoryUtil.GetSymbolById(symbolId);
                    LogUtil.Debug($"中奖-----symbolId:{symbolId}, itemEo:{SerializerUtil.SerializeJsonNet(multipEo)}");
                    if (multipEo != null)
                    {
                        int _singleMultiple = multipEo.SymbolMultiple3;
                        if (_sameCount == 4)
                        {
                            _singleMultiple = multipEo.SymbolMultiple4;
                        }
                        else if (_sameCount == 5)
                        {
                            _singleMultiple = multipEo.SymbolMultiple5;
                        }

                        RewardDetail rewardDetail = new()
                        {
                            LineId = lineNo,
                            Reward = (context.Chips.SingleAmount * _singleMultiple).AToM(context.CurrencyId),
                            SameCount = _sameCount,
                            SingleMultiple = _singleMultiple,
                            IndexHaveList = _IndexHaveList.ToList(),
                        };
                        context.RewardDetailList.Add(rewardDetail);
                        totalMultip.Add(_singleMultiple);
                    }
                }
            }
            context.HistoryMultip = string.Join("|", totalMultip);
            context.TotalMultip = totalMultip.Sum();
            context.WinAmount = (long)(context.TotalMultip * context.Chips.SingleAmount);
            await Settle_Main(tableList, context);
            //未中奖且牌面没有wild,更换牌面逻辑
            var _IsHave = tableList.SelectMany(list => list).Contains(WILD);
            if (totalMultip.Count == 0 && !_IsHave)
            {
                if (RandomUtil.IsOdds(0.25m))
                {
                    //替换牌面
                    //tableList = ChageTableList_B();
                }
            }
            List<int> symbolIds = Bulid_SymbolIds(context);

            List<int> indexes_0 = tableList[0].Select((value, index) => new { Value = value, Index = index })
                                       .Where(x => x.Value == JJ)
                                       .Select(x => x.Index)
                                       .ToList();

            if (indexes_0.Count > 0)
            {
                foreach (int index in indexes_0)
                {

                    tableList[0][index] = GetSymbolId_NotRepeat(tableList[1], symbolIds);
                }
            }
            List<int> indexes_2 = tableList[2].Select((value, index) => new { Value = value, Index = index })
                                 .Where(x => x.Value == JJ)
                                 .Select(x => x.Index)
                                 .ToList();

            if (indexes_2.Count > 0)
            {
                foreach (int index in indexes_2)
                {
                    var list = tableList[0].Concat(tableList[1]).ToList();
                    tableList[2][index] = GetSymbolId_NotRepeat(list, symbolIds);
                }
            }
            List<int> indexes_4 = tableList[4].Select((value, index) => new { Value = value, Index = index })
                                 .Where(x => x.Value == JJ)
                                 .Select(x => x.Index)
                                 .ToList();

            if (indexes_4.Count > 0)
            {
                foreach (int index in indexes_4)
                {
                    tableList[4][index] = GetSymbolId_NotRepeat(tableList[3], symbolIds);
                }
            }

            LogUtil.Debug("=====================" + SerializerUtil.SerializeJsonNet(tableList));
            context.SlotEleList = tableList;

            //查询奖池是否足够
            var flag = await CheckPoolReturn(context, context.WinAmount);
            context.IsWin = flag ? 1 : 0;

            //奖池不足
            if (!flag)
            {
                context.TriggerFreeSpin = 0;
                context.TriggerRespin = 0;
                context.RewardDetailList.Clear();
                context.SlotEleList = BuildTablePoolNo(context);
                LogUtil.Debug($"奖池不足-RewardDetailList: {SerializerUtil.SerializeJsonNet(context.RewardDetailList)},context.SlotEleList:{SerializerUtil.SerializeJsonNet(context.SlotEleList)}");
            }
            int _tempFree = context.TriggerFreeSpin;
            while (_tempFree > 0)//跟小老虎一样
            {
                await Spin_Free(context, _tempFree);
                _tempFree--;
            }
            int _tempRespin = context.TriggerRespin;
            while (_tempRespin > 0)//跟兔子一样
            {
                await Spin_Re(context, _tempRespin);
                _tempRespin--;
            }
        }
    }
}
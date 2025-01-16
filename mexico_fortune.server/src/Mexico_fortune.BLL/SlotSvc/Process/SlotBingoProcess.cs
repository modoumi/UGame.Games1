using Mexico_fortune.BLL.Caching;
using Mexico_fortune.DAL;
using TinyFx.Collections;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common;

namespace Mexico_fortune.BLL
{
    internal class SlotBingoProcess : SlotProcessBase
    {
        public override async Task Execute(SlotContext context)
        {
            var config = GmfDBCacheUtil.GetConfig();
            var bingoData = context.BingoData;
            var userDataDo = context.UserDataDo;

            var outTH = !context.IsFreeSpin
                ? (int)(userDataDo.BingoTotal + context.PartAmount.PartBingoAmount - (config.BingoTH * context.BetAmount))
                : (int)(userDataDo.BingoTotal - (config.BingoTH * context.BetAmount));
            bingoData.IsOutTH = outTH >= 0;
            var hasBonus = await context.UserSvc.GetBonus() > 0;
            if (bingoData.IsOutTH && !hasBonus)
            {
                userDataDo.BingoTotal = outTH;//只要抽取就扣减
                var winRatio = config.BingoTH / config.BingoPerValue;
                bingoData.IsWin = RandomUtil.IsOdds((decimal)winRatio, 100);
                if (bingoData.IsWin)
                {
                    var pool = GmfDBCacheUtil.GetBingoJPPool();
                    bingoData.JPPoolType = (JPPoolType)pool.JPPoolID;
                    bingoData.WinAmount = GetJPAmount(bingoData.JPPoolType, context.Chips, context.CurrencyId);
                    bingoData.IsWin = await CheckReturnPool(context, bingoData.WinAmount, SlotPartType.Bingo);
                }
            }
            if (bingoData.IsWin)
            {
                //bingoData.NewNums = GetWinNewNumsByHitLine(userDataDo.BingoHitLineNums, userDataDo.BingoHasNums);
                bingoData.NewNums = GetWinNewNums(userDataDo.BingoPanelNumTwoD, userDataDo.BingoHasNums);
                bingoData.IsWin = bingoData.NewNums?.Count > 0;
            }
            if (!bingoData.IsWin)
            {
                if (!bingoData.IsOutTH && !context.IsFreeSpin)
                    userDataDo.BingoTotal += context.PartAmount.PartBingoAmount;
                //bingoData.NewNums = GetLoseNewNumsByHitLine(userDataDo.BingoKeepNum, userDataDo.BingoHasNums);
                bingoData.NewNums = GetLoseNewNums(userDataDo.BingoKeepNums, userDataDo.BingoHasNums);
            }
            userDataDo.BingoHasNums.AddRange(bingoData.NewNums);
        }
        private int GetJPAmount(JPPoolType type, Gmf_chipsEO chips, string currencyId)
        {
            var ret = 0;
            switch (type)
            {
                case JPPoolType.Mini:
                    ret = chips.JPMini;
                    break;
                case JPPoolType.Minor:
                    ret = chips.JPMinor;
                    break;
                case JPPoolType.Major:
                    ret = chips.JPMajor;
                    break;
                case JPPoolType.Grand:
                    ret = chips.JPGrand;
                    break;
            }
            return (int)XxyyUtil.MToA((decimal)ret, currencyId);
        }

        // 指定中奖线
        private List<int> GetWinNewNumsByHitLine(int[] lineNums, List<int> hasNums)
        {
            var ret = lineNums.ToHashSet();
            hasNums.ForEach(x => { if (ret.Contains(x)) ret.Remove(x); });
            return ret.ToList();
        }
        // 任意中奖线
        private List<int> GetWinNewNums(int[,] panelNums, List<int> hasNums)
        {
            //避免同时两条线
            var hasSet = hasNums.ToHashSet();
            var lineList = new List<List<int>>();
            // 线中没有出现的数字集合
            for (int i = 0; i < 12; i++)
            {
                var lineNums = SlotUtil.GetBingoLineNums(panelNums, i + 1);
                lineList.Add(lineNums.Where(x => !hasSet.Contains(x)).OrderBy(x => x).ToList());
            }
            lineList.Sort((x, y) => x.Count.CompareTo(y.Count));
            var ret = new List<List<int>>();
            for (int i = 0; i < lineList.Count; i++)
            {
                var line = lineList[i];
                var flag = false;
                for (int j = i + 1; j < lineList.Count; j++)
                {
                    var nextLine = lineList[j];
                    if (line.Count == nextLine.Count)
                    {
                        flag = true;
                        for (int k = 0; k < line.Count; k++)
                        {
                            if (line[k] != nextLine[k])
                            {
                                flag = false;
                                break;
                            }
                        }
                    }
                    if (flag)
                    {
                        i = j;
                        break;
                    }
                }
                if (!flag)
                {
                    ret.Add(line);
                }
            }
            if (ret.Count > 0)
            {
                ret = ret.Where(x => x.Count != 4).ToList();
                return ret[new Random().Next(ret.Count)];
            }
            return new List<int>();
        }
        class BingoHitLineNumsInfo
        {
            public int LineId { get; set; }
            public HashSet<int> nohasNums { get; set; }
        }

        private List<int> GetLoseNewNumsByHitLine(int keepNum, List<int> hasNums)
        {
            var num = GmfDBCacheUtil.GetBingoNumCount();
            var ret = new HashSet<int>();
            // 过滤保留的
            for (int i = 1; i < 76; i++)
            {
                if (keepNum == i) continue;
                ret.Add(i);
            }
            // 移除已有的
            hasNums.ForEach(x =>
            {
                if (ret.Contains(x))
                    ret.Remove(x);
            });
            if (ret.Count < num)
                num = ret.Count;
            return RandomUtil.RandomNotRepeat(ret.ToArray(), num).ToList();
        }

        private List<int> GetLoseNewNums(HashSet<int> keepNums, List<int> hasNums)
        {
            var num = GmfDBCacheUtil.GetBingoNumCount();
            var ret = new HashSet<int>();
            // 过滤保留的
            for (int i = 1; i < 76; i++)
            {
                if (keepNums.Contains(i))
                    continue;
                ret.Add(i);
            }
            // 移除已有的
            hasNums.ForEach(x =>
            {
                if (ret.Contains(x))
                    ret.Remove(x);
            });
            if (ret.Count < num)
                num = ret.Count;
            return RandomUtil.RandomNotRepeat(ret.ToArray(), num).ToList();
        }
    }
}

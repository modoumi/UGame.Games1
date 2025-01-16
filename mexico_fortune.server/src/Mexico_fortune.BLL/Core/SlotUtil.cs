using Mexico_fortune.BLL.Caching;
using Mexico_fortune.DAL;
using System.Drawing;
using TinyFx.Collections;
using TinyFx.Data;
using TinyFx.Randoms;
using Xxyy.GameEAPI.Common.Enum;

namespace Mexico_fortune.BLL
{
    internal static class SlotUtil
    {
        #region Properties
        private static readonly Gmf_user_chips_dataMO _userDataMo = new();
        private static readonly Gmf_user_slotMO _slotMo = new();
        private static readonly Gmf_return_poolMO _poolMo = new();

        public static Point[,] BingoHitLineNums = new Point[12, 5]
        {
            { new Point(0, 0), new Point(0, 1), new Point(0, 2), new Point(0, 3), new Point(0, 4) },
            { new Point(1, 0), new Point(1, 1), new Point(1, 2), new Point(1, 3), new Point(1, 4) },
            { new Point(2, 0), new Point(2, 1), new Point(2, 2), new Point(2, 3), new Point(2, 4) },
            { new Point(3, 0), new Point(3, 1), new Point(3, 2), new Point(3, 3), new Point(3, 4) },
            { new Point(4, 0), new Point(4, 1), new Point(4, 2), new Point(4, 3), new Point(4, 4) },
            { new Point(0, 0), new Point(1, 0), new Point(2, 0), new Point(3, 0), new Point(4, 0) },
            { new Point(0, 1), new Point(1, 1), new Point(2, 1), new Point(3, 1), new Point(4, 1) },
            { new Point(0, 2), new Point(1, 2), new Point(2, 2), new Point(3, 2), new Point(4, 2) },
            { new Point(0, 3), new Point(1, 3), new Point(2, 3), new Point(3, 3), new Point(4, 3) },
            { new Point(0, 4), new Point(1, 4), new Point(2, 4), new Point(3, 4), new Point(4, 4) },
            { new Point(0, 0), new Point(1, 1), new Point(2, 2), new Point(3, 3), new Point(4, 4) },
            { new Point(4, 4), new Point(3, 3), new Point(2, 2), new Point(1, 1), new Point(0, 0) }
        };

        #endregion

        public static async Task CheckAndInitUserData(string userId, string operatorId, string currencyId)
        {
            //gmf_return_pool
            var poolItem = await _poolMo.GetByPKAsync(operatorId, currencyId);
            if (poolItem == null)
            {
                await _poolMo.AddAsync(new Gmf_return_poolEO
                {
                    OperatorID = operatorId,
                    CurrencyID = currencyId,
                    Value = 0
                });
            }
            // gmf_user_chips_data
            var count = await _userDataMo.GetCountAsync($"UserID=@UserID", userId);
            var chipsList = GmfDBCacheUtil.GetLoadChips(currencyId);
            if (count == chipsList.Count)
                return;
            if (count != 0)
                throw new Exception($"gmf_user_chips_data表数据错误。userId:{userId} currencyId:{currencyId} chips: {chipsList.Count} count:{count}");
            var list = new List<Gmf_user_chips_dataEO>();
            foreach (var chips in chipsList)
            {
                var item = new Gmf_user_chips_dataEO
                {
                    UserID = userId,
                    ChipsID = chips.ChipsId,
                    Status = (int)SlotUserStatus.Normal,
                    RecDate = DateTime.UtcNow,
                };
                SetUserChipsNewBingoData(item);
                list.Add(item);
            }
            await _userDataMo.AddAsync(list);
        }
        public static async Task AddSlotDetail(SlotContext context, long slotId, TransactionManager tm)
        {
            var item = new Gmf_user_slotEO
            {
                SlotID = slotId,
                UserID = context.UserId,
                ChipsID = context.ChipsId,
                OperatorID = context.OperatorId,
                CurrencyID = context.CurrencyId,
                IsFreeSpin = context.IsFreeSpin,
                PartBase = context.PartAmount.PartBaseAmount,
                PartBonus = context.PartAmount.PartBonusAmount,
                PartBingo = context.PartAmount.PartBingoAmount,
                PartIncome = context.PartAmount.PartIncomeAmount,
                //
                BingoIsOutTH = context.BingoData.IsOutTH,
                BingoIsWin = context.BingoData.IsWin,
                BingoJPPoolType = (int)context.BingoData.JPPoolType,
                //BingoMultip = context.BingoData.Multip,
                BingoTotal = context.UserDataDo.BingoTotal,
                BingoPanelNums = string.Join('|', context.UserDataDo.BingoPanelNums),
                BingoHitLine = context.UserDataDo.BingoHitLine,
                BingoKeepNum = context.UserDataDo.BingoKeepNum,
                BingoKeepNums = string.Join('|', context.UserDataDo.BingoKeepNums),
                BingoNewNums = string.Join('|', context.BingoData.NewNums),
                BingoHasNums = string.Join('|', context.UserDataDo.BingoHasNums),
                BingoWinAmount = context.BingoData.WinAmount,
                //
                BonusIsOutTH = context.BonusData.IsOutTH,
                BonusIsWin = context.BonusData.IsWin,
                BonusMultip = context.BonusData.Multip,
                BonusTotal = context.UserDataDo.BonusTotal,
                BonusSymbolNum = context.BonusData.SymbolNum,
                BonusNewRetriggerNum = context.BonusData.NewRetriggerNum,
                FreeSpinNum = context.UserDataDo.FreeSpinNum,
                RetriggerNum = context.UserDataDo.RetriggerNum,
                RetriggerList = string.Join('|', context.UserDataDo.RetriggerList),
                BonusWinAmount = context.BonusData.WinAmount,
                //
                BaseIsWin = context.BaseData.IsWin,
                BaseMultip = context.BaseData.Multip,
                BaseWinAmount = context.BaseData.WinAmount,

                TotalAmount = context.TotalAmount,
                SlotItemID = context.QueryData.ItemId,
                Status = (int)OrderStatus.Initial,
                RecDate = DateTime.UtcNow
            };
            await _slotMo.AddAsync(item, tm);
        }
        public static async Task UpdateUserData(SlotContext context, long slotId, TransactionManager tm)
        {
            var userDo = context.UserDataDo;
            var item = await _userDataMo.GetByPKAsync(context.UserId, context.ChipsId, tm, true);
            // bingo
            item.BingoTotal = userDo.BingoTotal;
            item.BingoLock = 0;
            if (context.BingoData.IsWin)
            {
                // panelNums
                userDo.BingoPanelNums = GetPanelNums();
                userDo.BingoPanelNumTwoD = ArrayUtil.OneToTwoD(userDo.BingoPanelNums, 5);
                item.BingoPanelNums = string.Join('|', userDo.BingoPanelNums);
                // hitLine + keepNum
                item.BingoHitLine = userDo.BingoHitLine = new Random().Next(1, 13);
                userDo.BingoHitLineNums = GetBingoLineNums(userDo.BingoPanelNumTwoD, userDo.BingoHitLine);
                item.BingoKeepNum = userDo.BingoKeepNum = GetBingoKeepNum(userDo.BingoPanelNumTwoD, item.BingoHitLine);
                // keepNums
                userDo.BingoKeepNums = GetBingoKeepNums(userDo.BingoPanelNumTwoD);
                item.BingoKeepNums = string.Join('|', userDo.BingoKeepNums);
                //
                userDo.BingoHasNums = new List<int>();
                item.BingoHasNums = null;
            }
            else
            {
                item.BingoHasNums = string.Join('|', userDo.BingoHasNums);
            }
            // bonus
            item.BonusTotal = userDo.BonusTotal;
            item.BonusLock = 0;
            item.FreeSpinNum = userDo.FreeSpinNum;
            if (item.FreeSpinNum > 0)
            {
                item.RetriggerNum = userDo.RetriggerNum;
                item.RetriggerList = string.Join('|', userDo.RetriggerList);
            }
            else
            {
                item.RetriggerNum = userDo.RetriggerNum = 0;
                userDo.RetriggerList = new List<int>();
                item.RetriggerList = null;
            }
            item.FreeSpinAmount = userDo.FreeSpinAmount;

            item.BaseLock = 0;
            item.SlotID = slotId;
            await _userDataMo.PutAsync(item, tm);
        }

        #region Utils
        private static int[] GetPanelNums()
        {
            var ret = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                var line = RandomUtil.RandomNotRepeat(15, 5);
                foreach (var v in line)
                {
                    ret.Add(v + 15 * i + 1);
                }
            }
            return ret.ToArray();
        }
        public static int[] GetBingoLineNums(int[,] panelNums, int lineId)
        {
            var points = ArrayUtil.GetTwoDRow(BingoHitLineNums, lineId - 1);
            return ArrayUtil.GetTwoDValues(panelNums, points);
        }
        private static int GetBingoKeepNum(int[,] panelNums, int lineId)
        {
            var arr = GetBingoLineNums(panelNums, lineId);
            return arr[new Random().Next(arr.Length)];
        }
        private static void SetUserChipsNewBingoData(Gmf_user_chips_dataEO item)
        {
            var panelNums = GetPanelNums();
            item.BingoPanelNums = string.Join('|', panelNums);
            item.BingoHitLine = new Random().Next(1, 13);
            var panelNumTwoD = ArrayUtil.OneToTwoD(panelNums, 5);
            item.BingoKeepNum = GetBingoKeepNum(panelNumTwoD, item.BingoHitLine);
            item.BingoKeepNums = string.Join('|', GetBingoKeepNums(panelNumTwoD));
        }

        // 获取12条线最少关键数
        private static HashSet<int> GetBingoKeepNums(int[,] panelNums)
        {
            var ret = new HashSet<int>();
            for (int i = 0; i < 12; i++)
            {
                var arr = GetBingoLineNums(panelNums, i + 1);
                var value = arr[new Random().Next(5)];
                if (!ret.Contains(value))
                    ret.Add(value);
            }
            return ret;
        }
        #endregion
    }
}

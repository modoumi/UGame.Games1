using TinyFx.Data;
using Xxyy.DAL;
using Xxyy.GameEAPI.Caching;
using Xxyy.GameEAPI.Common.Enum;

namespace Xxyy.GameEAPI.Common.Services
{
    public class UserService
    {
        public string UserId { get; set; }
        public UserService(string userId)
        {
            UserId = userId;
        }
        /// <summary>
        /// 获取余额
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="tm"></param>
        /// <param name="useBonus">是否使用bonus（bonus不参与第三方游戏，传入false）</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<long> GetBalance(string currencyId, TransactionManager tm = null, bool useBonus = false)
        {
            var ctype = DbCacheUtil.GetCurrencyType(currencyId);
            var userMo = GetUserMo();
            switch (ctype)
            {
                case CurrencyType.Cash:
                    if (useBonus)
                        return await userMo.GetCashByPKAsync(UserId, tm);
                    else
                    {
                        var row = await userMo.GetSingleRowAsync("Cash, Bonus", $"UserId='{UserId}'", null, null, tm);
                        var ret = row.ToInt64("Cash") - row.ToInt64("Bonus");
                        if (ret < 0)
                            throw new Exception("Cash-Bonus负数，账户异常");
                        return ret;
                    }
                case CurrencyType.Coin:
                    return await userMo.GetCoinByPKAsync(UserId, tm);
                case CurrencyType.Gold:
                    return await userMo.GetGoldByPKAsync(UserId, tm);
                case CurrencyType.Point:
                    return await userMo.GetPointByPKAsync(UserId, tm);
                case CurrencyType.SWB:
                    return await userMo.GetSWBByPKAsync(UserId, tm);
                default:
                    throw new Exception("未知的ctype");
            }
        }

        public async Task<long> GetBonus(TransactionManager tm = null)
            => await GetUserMo().GetBonusByPKAsync(UserId, tm);

        public async Task<BalanceInfo> GetBalanceInfo(TransactionManager tm = null, bool useBonus = false)
        {
            var userMo = GetUserMo();
            var row = await userMo.GetSingleRowAsync("Cash, Bonus,Coin,Gold,SWB,Point", $"UserId='{UserId}'", null, null, tm);
            var ret = new BalanceInfo
            {
                Cash = row.ToInt64("Cash"),
                Bonus = row.ToInt64("Bonus"),
                Coin = row.ToInt64("Coin"),
                Gold = row.ToInt64("Gold"),
                SWB = row.ToInt64("SWB"),
                Point = row.ToInt64("Point"),
            };
            if (!useBonus)
            {
                ret.Cash -= ret.Bonus;
                if (ret.Cash < 0)
                    throw new Exception("Cash-Bonus负数，账户异常");
            }
            return ret;
        }

        #region UpdateBalance
        public async Task<bool> UpdateBalance(string currencyId, long changeAmount, TransactionManager tm = null, bool useBonus = false, long changeBonus = 0)
            => await UpdateBalanceCore(currencyId, changeAmount, 0, tm, useBonus, changeBonus);
        public async Task<bool> UpdateBalanceByBet(string currencyId, long betAmount, TransactionManager tm = null, bool useBonus = false, long changeBonus = 0)
        {
            if (betAmount < 0)
                throw new Exception("UpdateBalanceByBet时，betAmount不能小于0");
            var changeAmount = -betAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, tm, useBonus, changeBonus);
        }
        public async Task<bool> UpdateBalanceByWin(string currencyId, long winAmount, TransactionManager tm = null, bool useBonus = false, long changeBonus = 0)
        {
            if (winAmount < 0)
                throw new Exception("UpdateBalanceByWin时，winAmount不能小于0");
            var changeAmount = winAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, tm, useBonus, changeBonus);
        }
        public async Task<bool> UpdateBalanceByBetWin(string currencyId, long betAmount, long winAmount, TransactionManager tm = null, bool useBonus = false, long changeBonus = 0)
        {
            if (betAmount < 0)
                throw new Exception("UpdateBalanceByBetWin时，betAmount不能小于0");
            if (winAmount < 0)
                throw new Exception("UpdateBalanceByBetWin时，winAmount不能小于0");
            var changeAmount = winAmount - betAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, betAmount, tm, useBonus, changeBonus);
        }
        public async Task<bool> UpdateBalanceByRollback(string currencyId, long refererBetAmount, long refererWinAmount, TransactionManager tm = null, bool useBonus = false, long changeBonus = 0)
        {
            if (refererBetAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererBetAmount不能小于0");
            if (refererWinAmount < 0)
                throw new Exception("UpdateBalanceByRollback时，refererWinAmount不能小于0");
            var changeAmount = refererBetAmount - refererWinAmount;
            return await UpdateBalanceCore(currencyId, changeAmount, 0, tm, useBonus, changeBonus);
        }

        /// <summary>
        /// 更新余额
        /// </summary>
        /// <param name="currencyId"></param>
        /// <param name="changeAmount">变化</param>
        /// <param name="betAmount"></param>
        /// <param name="tm"></param>
        /// <param name="useBonus">是否使用bonus（bonus不参与第三方游戏，传入false）</param>
        /// <param name="changeBonus">bonus的变动金额</param>
        /// <returns></returns>
        private async Task<bool> UpdateBalanceCore(string currencyId, long changeAmount, long betAmount, TransactionManager tm = null, bool useBonus = false, long changeBonus = 0)
        {
            if (changeAmount == 0)
            {
                if (changeBonus != 0)
                    throw new Exception("UpdateBalance时,changeAmount=0,则changeBonus必须=0");
                return true;
            }
            if (betAmount < 0)
                throw new Exception("UpdateBalance时,betAmount不能小于0");

            var ctype = DbCacheUtil.GetCurrencyType(currencyId);

            var set = $"{ctype}={ctype}+{changeAmount}";
            if (ctype == CurrencyType.Cash && useBonus && changeBonus != 0)
                set += $",Bonus=Bonus+{changeBonus}";

            var where = $"UserId='{UserId}' ";
            if (betAmount > 0)
            {
                where += ctype == CurrencyType.Cash && !useBonus
                   ? $" and {ctype}-Bonus>={betAmount}"
                   : $" and {ctype}>={betAmount}";
            }
            where += ctype == CurrencyType.Cash && !useBonus
                ? $" and {ctype}+{changeAmount}-Bonus>=0"
                : $" and {ctype}+{changeAmount}>=0";

            var ret = await GetUserMo().PutAsync(set, where, tm);
            return ret == 1;
        }
        #endregion

        #region Utils
        private S_userMO _userMo;
        public S_userMO GetUserMo()
            => _userMo ??= DbSink.BuildUserMo(UserId);
        private S_user_exMO _userExMo;
        public S_user_exMO GetUserExMo()
            => _userExMo ??= DbSink.BuildUserExMo(UserId);
        private S_requireflow_orderMO _requireflowOrderMo;
        public S_requireflow_orderMO GetRequireflowOrderMo()
            => _requireflowOrderMo ??= DbSink.BuildRequireFlowOrderMo(UserId);
        #endregion
    }

    public class BalanceInfo
    {
        public long Cash { get; set; }
        public long Bonus { get; set; }
        public long Coin { get; set; }
        public long Gold { get; set; }
        public long Point { get; set; }
        public long SWB { get; set; }
    }
}

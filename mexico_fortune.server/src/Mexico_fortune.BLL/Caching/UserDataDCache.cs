using Mexico_fortune.DAL;
using TinyFx;
using TinyFx.Caching;
using TinyFx.Collections;
using TinyFx.Configuration;
using TinyFx.Extensions.StackExchangeRedis;

namespace Mexico_fortune.BLL.Caching
{
    public class UserDataDCache : RedisHashClient<UserDataDO>
    {
        private int EXPIRE_MINUTES = 30;
        public string UserId { get; set; }
        private Gmf_user_chips_dataMO _userChipsMo = new();

        public UserDataDCache(string userId)
        {
            UserId = userId;
            RedisKey = GetProjectRedisKey(userId);
            EXPIRE_MINUTES = ConfigUtil.Environment.IsDebug
                ? int.MaxValue : 30;
        }

        protected override async Task<CacheValue<UserDataDO>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var chipsId = field.ToInt32();
            var item = _userChipsMo.GetByPK(UserId, chipsId);
            if (item == null)
                throw new Exception($"gmf_user_chips_data数据不存在。userId: {UserId} chipsId: {chipsId}");
            var ret = new CacheValue<UserDataDO>();
            var value = new UserDataDO
            {
                BingoTotal = item.BingoTotal,
                BingoHitLine = item.BingoHitLine,
                BingoKeepNum = item.BingoKeepNum,
                BonusTotal = item.BonusTotal,
                FreeSpinNum = item.FreeSpinNum,
                RetriggerNum = item.RetriggerNum,
                FreeSpinAmount = item.FreeSpinAmount,
                UserStatus = (SlotUserStatus)item.Status
            };

            var arrStr = item.BingoPanelNums?.Trim();
            if (!string.IsNullOrEmpty(arrStr))
                value.BingoPanelNums = arrStr.Split('|').Select(x => x.ToInt32()).ToArray();
            arrStr = item.BingoKeepNums?.Trim();
            if (!string.IsNullOrEmpty(arrStr))
                value.BingoKeepNums = arrStr.Split("|").Select(x => x.ToInt32()).ToHashSet();
            arrStr = item.BingoHasNums?.Trim();
            if (!string.IsNullOrEmpty(arrStr))
                value.BingoHasNums = arrStr.Split("|").Select(x => x.ToInt32()).ToList() ?? new List<int>();
            else
                value.BingoHasNums = new List<int>();
            arrStr = item.RetriggerList?.Trim();
            if (!string.IsNullOrEmpty(arrStr))
                value.RetriggerList = arrStr.Split("|").Select(x => x.ToInt32()).ToList() ?? new List<int>();
            value.BingoPanelNumTwoD = ArrayUtil.OneToTwoD(value.BingoPanelNums, 5);
            value.BingoHitLineNums = SlotUtil.GetBingoLineNums(value.BingoPanelNumTwoD, value.BingoHitLine);
            ret.Value = value;
            ret.HasValue = true;
            return ret;
        }

        public async Task<UserDataDO> GetUserChipsDataDo(int chipsId, bool enforce = false)
        {
            var ret = await GetOrLoadAsync(chipsId.ToString(), enforce);
            if (!ret.HasValue)
                throw new Exception($"UserBingoNumDCache不存在UserChipsDataDO。userId:{UserId} chipsId:{chipsId}");
            //ret.Value.BingoPanelNumTwoD = ArrayUtil.OneToTwoD(ret.Value.BingoPanelNums, 5);
            //ret.Value.BingoHitLineNums = SlotUtil.GetBingoLineNums(ret.Value.BingoPanelNumTwoD, ret.Value.BingoHitLine);
            await KeyExpireMinutesAsync(EXPIRE_MINUTES);
            return ret.Value;
        }

        public async Task SetUserChipsDataDo(int chipId, UserDataDO value)
        {
            await SetAsync(chipId.ToString(), value);
        }
    }

    public class UserDataDO
    {
        public long BingoTotal { get; set; }
        public int[] BingoPanelNums { get; set; }
        public int[,] BingoPanelNumTwoD { get; set; } //
        public int BingoHitLine { get; set; }
        public int[] BingoHitLineNums { get; set; }
        public int BingoKeepNum { get; set; }
        public HashSet<int> BingoKeepNums { get; set; }
        /// <summary>
        /// 已出的75个数字,按顺序|分割
        /// </summary>
        public List<int> BingoHasNums { get; set; }

        public long BonusTotal { get; set; }
        /// <summary>
        /// 当前剩余freespin
        /// </summary>
        public int FreeSpinNum { get; set; }
        /// <summary>
        /// 奖励的retrigger总数
        /// </summary>
        public int RetriggerNum { get; set; }
        /// <summary>
        /// freespin过程中base环节总奖励金额
        /// </summary>
        public long FreeSpinAmount { get; set; }
        /// <summary>
        /// 出retrigger序列
        /// </summary>
        public List<int> RetriggerList { get; set; } = new();

        public SlotUserStatus UserStatus { get; set; }
    }
}

using Mexico_fortune.DAL;
using TinyFx;
using TinyFx.Caching;
using TinyFx.Extensions.StackExchangeRedis;

namespace Mexico_fortune.BLL.Caching
{
    internal class SlotItemDCache : RedisHashClient<List<long>>
    {
        private static readonly SlotItemDCache _instance = new SlotItemDCache();
        public static SlotItemDCache Create() => _instance;

        private static Gmf_itemMO _itemMo = new();
        private SlotItemDCache()
        {
            RedisKey = GetProjectRedisKey();
        }
        public static string GetField(int multip, int bonusNum, int bingoNum)
            => $"{multip}|{bonusNum}|{bingoNum}";

        protected override async Task<CacheValue<List<long>>> LoadValueWhenRedisNotExistsAsync(string field)
        {
            var ret = new CacheValue<List<long>>();
            var keys = field.Split('|');
            var multip = keys[0].ToInt32();
            var bonusNum = keys[1].ToInt32();
            var bingoNum = keys[2].ToInt32();
            ret.Value = await GetItemIds(multip, bonusNum, bingoNum);
            ret.HasValue = true;
            return ret;
        }

        public static async Task<List<long>> GetItemIds(int multip, int bonusNum, int bingoNum)
        {
            var ret = new List<long>();
            var where = $"Multip={multip} and BonusNum={bonusNum} and BingoNum={bingoNum}";
            foreach (var item in await _itemMo.GetAsync(where))
                ret.Add(item.ItemID);
            return ret;
        }
    }
}

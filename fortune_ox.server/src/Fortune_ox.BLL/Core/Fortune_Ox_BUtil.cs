using Fortune_ox.BLL.Caching;
using TinyFx;
using TinyFx.Logging;
using TinyFx.Randoms;
using static Xxyy.GameEAPI.Core.GameEAPIUtil;

namespace Fortune_ox.BLL
{
    public static partial class FortuneUtil
    {
        public static List<List<int>> ChageTableList(BetContext context)
        {
            return RandomUtil.IsOdds(0.35m) ? ChageTableList_B() : BuildTablePoolNo(context);
        }

        /// <summary>
        /// 主轴按权重取图标
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> ChageTableList_B()
        {
            var list = MemoryUtil.GetWeightChange();

            List<List<int>> tableListY = new() {
                GetRandomObjects(list.Select(x => x.Y1).ToList(), 3),
                GetRandomObjects(list.Select(x => x.Y2).ToList(), 4),
                GetRandomObjects(list.Select(x => x.Y3).ToList(), 3),
            };

            LogUtil.Info($"Fortune_ox ChageTableList_B tableListY:  {SerializerUtil.SerializeJsonNet(tableListY)}");
            return tableListY;
        }
    }
}
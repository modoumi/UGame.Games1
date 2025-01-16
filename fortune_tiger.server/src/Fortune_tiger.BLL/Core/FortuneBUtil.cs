using Fortune_tiger.BLL.Caching;
using Fortune_tiger.DAL;
using TinyFx;
using TinyFx.Logging;

namespace Fortune_tiger.BLL
{
    public static partial class FortuneUtil
    {
        public static Slot_config_base_otherEO GetWeightBaseOther()
        {
            var list = MemoryUtil.GetBaseOtherList();
            //中奖几率随机数 [0,100)
            var count = list.Sum(x => x.Weight);
            var random = new Random().Next(count);
            int startNum = 0;
            foreach (var w in list)
            {
                if (random >= startNum && random < (w.Weight + startNum))
                {
                    return w;
                }
                startNum += w.Weight;
            }
            return null;
        }
        /// <summary>
        /// 根据权重取哪个base
        /// </summary>
        /// <returns></returns>
        private static List<List<WeightColumn>> GetWeightBase_B()
        {
            List<int> list = new List<int> { 4244, 5742, 10, 4 };
            //中奖几率随机数 [0,100)
            var count = list.Sum();
            var random = new Random().Next(count);
            int startNum = 0;
            int startIndex = 1;
            foreach (var w in list)
            {
                if (random >= startNum && random < (w + startNum))
                {
                    string baseName = $"base_{startIndex}";
                    return MemoryUtil.BuildBase_B(baseName);
                }
                startNum += w;
                startIndex++;
            }
            return null;
        }

        /// <summary>
        /// 构建牌面权重方法
        /// </summary>
        /// <returns></returns>
        private static List<List<WeightColumn>> GetWeightBase0_B()
        {
            List<int> list = new() { 5, 3, 2 };
            //中奖几率随机数 [0,100)
            var count = list.Sum();
            var random = new Random().Next(count);
            int startNum = 0;
            int startIndex = 2;
            foreach (var w in list)
            {
                if (random >= startNum && random < (w + startNum))
                {
                    string baseName = $"base_0_{startIndex}";
                    return MemoryUtil.BuildBase_B(baseName);
                }
                startNum += w;
                startIndex++;
            }
            return null;
        }

        /// <summary>
        /// 主轴按权重取图标
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> GetBaseWeight_B()
        {
            var list = GetWeightBase_B();

            List<List<int>> tableListY = new();

            foreach (var columnsList in list)
            {
                //中奖几率随机数 [0,100)
                var count = columnsList.Sum(x => x.WeightVal);
                var random = new Random().Next(count);

                int startNum = 0;
                int startIndex = 0;
                foreach (var w in columnsList)//columnsList N个轴的集合
                {
                    if (random >= startNum && random < (w.WeightVal + startNum))
                    {
                        List<int> y1 = new();
                        for (int i = 0; i < 3; i++)
                        {
                            int index = (startIndex + i) % columnsList.Count;
                            y1.Add(columnsList[index].WeightId);
                        }
                        tableListY.Add(y1);
                        break;
                    }
                    startNum += w.WeightVal;
                    startIndex++;
                }
            }
            LogUtil.Info($"GetBaseWeight tableListY:  {SerializerUtil.SerializeJsonNet(tableListY)}");
            return tableListY;
        }

        /// <summary>
        /// 主轴按权重取图标
        /// </summary>
        /// <returns></returns>
        public static List<List<int>> ChageTableList_B()
        {
            //临时算法
            var list = GetWeightBase0_B();

            List<List<int>> tableListY = new();

            foreach (var columnsList in list)
            {
                //中奖几率随机数 [0,100)
                var count = columnsList.Sum(x => x.WeightVal);
                var random = new Random().Next(count);

                int startNum = 0;
                int startIndex = 0;
                foreach (var w in columnsList)
                {
                    if (random >= startNum && random < (w.WeightVal + startNum))
                    {
                        List<int> y1 = new();
                        for (int i = 0; i < 3; i++)
                        {
                            int index = (startIndex + i) % columnsList.Count;
                            y1.Add(columnsList[index].WeightId);
                        }
                        tableListY.Add(y1);
                        break;
                    }
                    startNum += w.WeightVal;
                    startIndex++;
                }
            }
            LogUtil.Info($"ChageTableList_B tableListY:  {SerializerUtil.SerializeJsonNet(tableListY)}");
            return tableListY;
        }
    }
}

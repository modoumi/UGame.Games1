namespace Mexico_fortune.BLL
{
    public class LoadIpo
    {
        public string UserId { get; set; }
        public string CurrencyId { get; set; }
    }
    public class LoadDto
    {
        public LoadPlayerInfo PlayerInfo { get; set; } = new();
        public List<LoadGameInfo> GameInfo { get; set; } = new();
        public LoadMeta Meta { get; set; } = new();
    }
    public class LoadPlayerInfo
    {
        public decimal Balance { get; set; }
    }
    public class LoadGameInfo
    {
        public int ChipsId { get; set; }
        public int FreeSpinCount { get; set; }
        /// <summary>
        /// free spin次数的总奖励，如果耗光重置为0，用户退出也需要记录，下一次进入还得有
        /// </summary>
        public int FreeSpinTotalReward { get; set; }
        public LoadLottoryInfo LottoryInfo { get; set; }
    }
    public class LoadLottoryInfo
    {
        /// <summary>
        /// 彩票25球信息
        /// [[1,16,31,46,61], [2,17,32,47,62], [3,18,33,48,63], [4,19,34,49,64], [5,20,35,50,65]]
        /// </summary>
        public List<int[]> LottoryEle { get; set; }
        /// <summary>
        /// 75元素出现信息:[1,4,8,10]
        /// </summary>
        public List<int> AppearEle { get; set; } = new();
    }

    public class LoadMeta
    {
        /// <summary>
        /// 筹码下注值和对应jp档位配置
        /// </summary>
        public List<LoadChips> Chips { get; set; }
        /// <summary>
        /// 线束位置配置，一共50个
        /// </summary>
        public List<int[]> Lines { get; set; }
        /// <summary>
        /// slot上元素配置，主要用于显示paytable
        /// </summary>
        public List<LoadSlotEle> SlotEles { get; set; }
        /// <summary>
        /// 就是super win, mega win, big win, epic win对应的倍数档位，所有的bet对应的档位都是固定的
        /// </summary>
        public int[] WinTypeMultis { get; set; }
    }
    public class LoadChips
    {
        public int ChipsId { get; set; }
        public double BetMoney { get; set; }
        public List<int> JpBonusList { get; set; }
    }
    public class LoadSlotEle
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public List<double> MultiList { get; set; }
    }
}

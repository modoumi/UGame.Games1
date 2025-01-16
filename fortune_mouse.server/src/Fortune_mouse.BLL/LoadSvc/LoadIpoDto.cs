namespace Fortune_mouse.BLL
{
    public class LoadIpo
    {
        public string UserId { get; set; }
    }

    public class LoadDto
    {
        public PlayerInfo PlayerInfo { get; set; } = new();
        public List<GameData> GameDataList { get; set; } = new();
        public ResultInfo LastBetInfo { get; set; } = new();
        public Meta Meta { get; set; } = new();
    }


    public class PlayerInfo
    {
        public decimal Balance { get; set; }

    }

    public class GameData
    {
        public decimal ChipsId { get; set; } //Chipsid
        /*  public int FreeSpinCount { get; set; }//免费摇奖次数
          public decimal FreeSpinTotalReward { get; set; }//free spin次数的总奖励，如果耗光重置为0，用户退出也需要记录，下一次进入还得有*/
    }

    public class Meta
    {
        public List<Chips> Chips { get; set; } = new();
        public List<int[]> Lines { get; set; } = new();
        public List<SlotEle> SlotEles { get; set; } = new();
        public List<int> WinTypeMultis { get; set; } = new();
    }
    public class Chips
    {
        public int ChipsId { get; set; }
        public decimal Bet { get; set; }
        public int IsShortcut { get; set; }
    }
    public class SlotEle
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public List<int> MultiList { get; set; } = new();
    }
}
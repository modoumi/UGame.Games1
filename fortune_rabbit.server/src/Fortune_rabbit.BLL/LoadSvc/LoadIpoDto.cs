namespace Fortune_rabbit.BLL
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
    }

    public class Meta
    {
        //单线下注配置
        public List<decimal> BetSingleLineList { get; set; } = new();
        //单线下注倍数配置
        public List<int> MultiList { get; set; } = new();
        public List<Chips> Chips { get; set; } = new();
        public List<int[]> Lines { get; set; } = new();
        public List<SlotEle> SlotEles { get; set; } = new();
        public List<int> WinTypeMultis { get; set; } = new();
        public List<TMultip> TMultipList { get; set; } = new();
    }

    public class TMultip
    {
        public int TID { get; set; }
        public float Multip { get; set; }
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
using Mexico_fortune.BLL.Caching;

namespace Mexico_fortune.BLL
{
    internal class SlotBaseProcess : SlotProcessBase
    {
        public override async Task Execute(SlotContext context)
        {
            var baseData = context.BaseData;
            var snum = context.BingoData.SymbolNum + context.BingoData.NewNums.Count;
            var baseWeightEo = snum > 3
                ? GmfDBCacheUtil.GetRandomMultip(0)
                : GmfDBCacheUtil.GetRandomMultip(1);
            baseData.Multip = baseWeightEo.Multip;
            baseData.WinAmount = baseWeightEo.Multip * context.BetAmount / 50 / 10;
            baseData.IsWin = (int)(baseWeightEo.HitRatio * 10000) > new Random().Next(10000);
            if (baseData.IsWin)
                baseData.IsWin = await CheckReturnPool(context, baseData.WinAmount, SlotPartType.Base);
            if (baseData.IsWin)
            {
                context.TotalAmount = baseData.WinAmount;
                if (context.IsFreeSpin)
                    context.UserDataDo.FreeSpinAmount += baseData.WinAmount;
            }
            if (context.BingoData.IsWin)
                context.TotalAmount += context.BingoData.WinAmount;
        }
    }
}

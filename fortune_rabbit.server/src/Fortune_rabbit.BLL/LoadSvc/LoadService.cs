﻿using Fortune_rabbit.BLL.Caching;
using Fortune_rabbit.DAL;
using TinyFx;
using TinyFx.Data.SqlSugar;
using TinyFx.Logging;
using Xxyy.GameEAPI.Common;
using Xxyy.GameEAPI.Core;

namespace Fortune_rabbit.BLL
{
    public class LoadService : RootService
    {
        private readonly Fra_bet_detailMO mo = new();
        public async Task<LoadDto> Load(LoadIpo ipo)
        {
            await CheckIdentityAndMock(ipo.UserId);
            var userExt = await CheckUserExtAsync(ipo.UserId);
            await CheckConfigAsync(userExt.OperatorID, userExt.CurrencyID);

            var ret = new LoadDto();
            ret.PlayerInfo.Balance = await GameEAPIUtil.GetBalanceMoney(ipo.UserId, userExt.AppID, userExt.CurrencyID);
            var chipsList = MemoryUtil.GetChipsList;
            ret.Meta.BetSingleLineList = new List<decimal> { 0.05m, 0.5m, 4m };
            for (int i = 1; i <= 10; i++) { ret.Meta.MultiList.Add(i); }
            foreach (var item in chipsList)
            {
                ret.Meta.Chips.Add(new Chips
                {
                    ChipsId = item.ChipsID,
                    Bet = item.BetAmount.AToM(userExt.CurrencyID),
                    IsShortcut = item.IsShortcut,
                });

            }
            var lines = MemoryUtil.GetLineList();
            foreach (var item in lines)
            {
                int[] line = Array.ConvertAll(item.Line.Split(","), x => int.Parse(x));
                ret.Meta.Lines.Add(line);
            }
            foreach (var item in MemoryUtil.GetItemList())
            {
                ret.Meta.SlotEles.Add(new SlotEle
                {
                    Id = item.ItemID,
                    Type = item.IconType,
                    MultiList = new List<int> { item.ItemBaseMultip },
                });
            }
            var config = MemoryUtil.GetConfig(userExt.OperatorID, userExt.CurrencyID);
            ret.Meta.WinTypeMultis = SerializerUtil.DeserializeJsonNet<List<int>>(config.MultipArray);
            foreach (var item in MemoryUtil.GetWeightList_t())
            {
                ret.Meta.TMultipList.Add(new TMultip { TID = item.TID, Multip = item.Multip });
            }
            foreach (var item in chipsList)
            {
                ret.GameDataList.Add(new GameData
                {
                    ChipsId = item.ChipsID,
                });
            }
            //  var list = DbUtil.GetRepository<Sfra_bet_detailEO>().GetList(d => d.UserID.Equals(userExt.UserID)).OrderByDescending(d => d.RecDate).Skip(0).Take(1).ToList();
            /*  using (var client = DbUtil.GetDb())
              {
                  client.Queryable<Sfra_bet_detailEO>().Where(d => d.UserID.Equals(userExt.UserID)).OrderByDescending(d => d.RecDate).FirstAsync();
              }*/

            var list = await mo.GetAsync($"UserId=@UserId ORDER BY RecDate DESC LIMIT 1", userExt.UserID);
            if (list == null || list.Count == 0)
            {
                ret.LastBetInfo.GameInfoList.Add(new GameInfo
                {
                    SlotEles = SerializerUtil.DeserializeJsonNet<List<List<int>>>(config.DefaultSlotArray)
                });
            }
            else
            {
                var detail = list.First();
                ret.LastBetInfo.GameInfoList = FortuneUtil.BuildGameInfoList(detail, userExt.CurrencyID, out decimal totalwin);
            }

            LogUtil.Debug($"===============:{SerializerUtil.SerializeJsonNet(ret)}");
            return ret;
        }
    }
}

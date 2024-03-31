﻿using EggLink.DanhengServer.Database;
using EggLink.DanhengServer.Enums;
using EggLink.DanhengServer.Proto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Data.Custom
{
    public class BannersConfig
    {
        public List<BannerConfig> Banners { get; set; } = [];
    }

    public class BannerConfig
    {
        public int GachaId { get; set; }
        public long BeginTime { get; set; }
        public long EndTime { get; set; }
        public GachaTypeEnum GachaType { get; set; }
        public List<int> RateUpItems5 { get; set; } = [];
        public List<int> RateUpItems4 { get; set; } = [];
        public int GetRateUpItem5Chance { get; set; } = 6;  // 0.6% chance (0.6%*1000)
        public int MaxCount { get; set; } = 90;
        public int EventChance { get; set; } = 50;

        public int DoGacha(List<int> goldAvatars, List<int> purpleAvatars, List<int> purpleWeapons, List<int> goldWeapons, List<int> blueWeapons, Database.Gacha.GachaData data)
        {
            var random = new Random();
            data.LastGachaFailedCount += 1;
            int item;

            var allGoldItems = new List<int>();
            allGoldItems.AddRange(goldAvatars);
            allGoldItems.AddRange(goldWeapons);

            var allNormalItems = new List<int>();
            allNormalItems.AddRange(purpleAvatars);
            allNormalItems.AddRange(purpleWeapons);

            if (data.LastGachaFailedCount >= MaxCount || IsRateUp())
            {
                data.LastGachaFailedCount = 0;
                if (GachaType == GachaTypeEnum.WeaponUp)
                {
                    item = GetRateUpItem5(goldWeapons, data.LastWeaponGachaFailed);
                    if (RateUpItems5.Contains(item))
                    {
                        data.LastWeaponGachaFailed = false;
                    } else
                    {
                        data.LastWeaponGachaFailed = true;
                    }
                } else if (GachaType == GachaTypeEnum.AvatarUp)
                {
                    item = GetRateUpItem5(goldAvatars, data.LastAvatarGachaFailed);
                    if (RateUpItems5.Contains(item))
                    {
                        data.LastAvatarGachaFailed = false;
                    }
                    else
                    {
                        data.LastAvatarGachaFailed = true;
                    }
                } else
                {
                    item = GetRateUpItem5(allGoldItems, false);
                }
            } else
            {
                // 4 - 3 star
                if (IsRate4())
                {
                    if (IsRateUp4())
                    {
                        item = RateUpItems4[random.Next(0, RateUpItems4.Count)];
                    } else
                    {
                        item = allNormalItems[random.Next(0, allNormalItems.Count)];
                    }
                } else
                {
                    item = blueWeapons[random.Next(0, blueWeapons.Count)];
                }
            }
            DatabaseHelper.Instance?.UpdateInstance(data);

            return item;
        }

        public bool IsEvent()
        {
            var random = new Random();
            return random.Next(0, 100) < EventChance;
        }

        public bool IsRateUp()
        {
            var random = new Random();
            return random.Next(0, 1000) < GetRateUpItem5Chance;
        }

        public bool IsRateUp4()
        {
            var random = new Random();
            return random.Next(0, 1000) < 50;
        }

        public bool IsRate4()
        {
            var random = new Random();
            return random.Next(0, 1000) < 61;
        }

        public int GetRateUpItem5(List<int> gold, bool forceUp)
        {
            var random = new Random();
            if (IsEvent() || forceUp)
            {
                return RateUpItems5[random.Next(0, RateUpItems5.Count)];
            } else
            {
                return gold[random.Next(0, gold.Count)];
            }
        }

        public GachaInfo ToInfo(List<int> goldAvatar, List<int> purpleAvatar, List<int> purpleWeapon, List<int> goldWeapon)
        {
            var info = new GachaInfo()
            {
                GachaId = (uint)GachaId,
                DetailWebview = "",
                DropHistoryWebview = "",
            };

            if (GachaType != GachaTypeEnum.Normal)
            {
                info.BeginTime = BeginTime;
                info.EndTime = EndTime;
            }
            if (GachaId == 1001)
            {
                info.PrizeItemList.AddRange(goldAvatar.Select(id => (uint)id));
                info.PrizeItemList.AddRange(purpleAvatar.Select(id => (uint)id));
                info.PrizeItemList.AddRange(goldWeapon.Select(id => (uint)id));
                info.PrizeItemList.AddRange(purpleWeapon.Select(id => (uint)id));
                info.GFKJABKCLEL = new()
                {
                    IsClaimed = true  // TODO: Implement this
                };
            } 
            else
            {
                if (RateUpItems5.Count > 0)
                {
                    info.PrizeItemList.AddRange(RateUpItems5.Select(id => (uint)id));
                    info.ItemDetailList.AddRange(RateUpItems5.Select(id => (uint)id));
                }

                if (RateUpItems4.Count > 0)
                {
                    info.PrizeItemList.AddRange(RateUpItems4.Select(id => (uint)id));
                }
            }

            return info;
        }
    }
}

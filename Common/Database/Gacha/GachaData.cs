﻿using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Database.Gacha
{
    [SugarTable("Gacha")]
    public class GachaData : BaseDatabaseData
    {
        [SugarColumn(IsJson = true)]
        public List<GachaInfo> GachaHistory { get; set; } = [];
        public bool LastAvatarGachaFailed { get; set; } = false;
        public bool LastWeaponGachaFailed { get; set; } = false;
        public int LastGachaFailedCount { get; set; } = 0;
    }

    public class GachaInfo
    {
        public int GachaId { get; set; }
        public long Time { get; set; }
        public int ItemId { get; set; }
    }
}

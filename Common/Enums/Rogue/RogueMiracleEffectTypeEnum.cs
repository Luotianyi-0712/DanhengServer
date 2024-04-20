﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggLink.DanhengServer.Enums.Rogue
{
    public enum RogueMiracleEffectTypeEnum
    {
        // effects

        None = 0,
        ExtraBuffSelect = 1,
        ExtraFreeBuffRoll = 2,
        SetSelectBuffLevel = 3,
        ReviveLineupAvatar = 4,
        GetMiracle = 5,
        GetRogueBuff = 6,
        SetSelectBuffGroup = 7,
        AddMazeBuff = 8,
        ChangeItemRatio = 9,
        ChangeItemNum = 10,
        ChangeCostRatio = 11,
        ChangeLineupInfo = 12,
        RepairRandomMiracle = 13,
        EnhanceRandomBuff = 14,
        ReplaceAllMiracles = 15,
        DoAllEffects = 16,
        DoRandomEffect = 17,
        DestroyMiracle = 18,
        CostDurability = 19,
        GetRogueBuffByAeon = 20,
        ChangeItemNumByArg = 21,
        RankupInBattle = 22,

        // events

        OnGetMiracle = 100,
        OnStartBattle = 101,
        OnEndBattle = 102,
        OnEnterNextRoom = 103,
        OnDestroy = 104,
        OnGainMoney = 105,
        OnDestroyProp = 106,
        OnGenerateBuffMenu = 107,

        // arguments

        CurMoney = 200,
        CurDestroyCount = 201,
        AvatarWithLeastHP = 202,
    }
}

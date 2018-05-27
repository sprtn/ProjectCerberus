﻿using System;
using System.Collections.Generic;
using System.Linq;
using ToolLibrary.Dungeons.Characters.Race.SizeModifiers;
using static ToolLibrary.Dungeons.Characters.Race.SizeModifiers.DungeonRace;

namespace ToolLibrary.Dungeons.Characters.Race
{
    public partial class Race
    {
        //private int attackAndArmorClassModifier;
        private string raceSizeCategory;
        private int hideModifier;
        private int naturalReach;
        private double spaceSize;
        private int specialAttackModifier;

        public Race(RaceEnums raceEnum)
        {
            var raceName = Enum.GetName(typeof(RaceEnums), raceEnum);

            RaceEnums re = (RaceEnums) Enum.Parse(typeof(RaceEnums), raceName);
            SizeAttackAndArmorClassModifier attackAndArmorClassModifier =
                (SizeAttackAndArmorClassModifier) Enum.Parse(typeof(SizeAttackAndArmorClassModifier), raceName);
        }
    }
}

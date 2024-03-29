﻿using Shared.Dungeons.Proficiencies.BaseProficiencyClass;

namespace Shared.Dungeons.SavingThrows
{
    public class SavingThrow : ProficiencyBools
    {
        public SavingThrow(string title, bool hasProficiency, int abilityModifier, string description) : base(title, hasProficiency, abilityModifier, description)
        {
            Title = title;
            HasProficiency = hasProficiency;
            AbilityModifier = abilityModifier;
            Description = description;
        }
    }
}
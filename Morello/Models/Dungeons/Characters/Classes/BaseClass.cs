using System.Collections.Generic;
using Shared.Dungeons.Proficiencies.BaseProficiencyClass;
using Shared.Dungeons.Skills;

namespace Shared.Dungeons.Mobs.Classes
{
    public class BaseClass
    {
        #region BaseClass variables
        // Description / Misc
        public string ClassDescription { get; }
        
        // Primary ability
        public int PrimaryAbility { get; set; }

        // Saving throws (can be multiple, and can be changed at a later stage)
        public Proficiencies.SavingThrows.SavingThrows SavingThrows { get; }

        // Hit points
        Dice.Dice Dice { get; set; }

        // Proficiencies
        public List<ProficiencyBools> ArmorProficiencies { get; set; }
        public List<ProficiencyBools> WeaponProficiencies { get; set; }
        public List<ProficiencyBools> ToolProficiencies { get; set; }

        // Skills
        public List<Skill> Skills { get; set; }
        #endregion

        public BaseClass(string classDescription, int primaryAbility, Proficiencies.SavingThrows.SavingThrows savingThrows, Dice.Dice dice, List<ProficiencyBools> armorProficiencies, List<ProficiencyBools> weaponProficiencies, List<ProficiencyBools> toolProficiencies, List<Skill> skills)
        {
            #region set input data to local values

            ClassDescription = classDescription;
            PrimaryAbility = primaryAbility;
            SavingThrows = savingThrows;
            Dice = dice;
            ArmorProficiencies = armorProficiencies;
            WeaponProficiencies = weaponProficiencies;
            ToolProficiencies = toolProficiencies;
            Skills = skills;

            #endregion
        }

        //Equipment

    }
}

using System.Collections.Generic;
using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;
using ToolLibrary.Dungeons.Skills;
using ToolLibrary.Dungeons.Dice;

namespace ToolLibrary.Dungeons.Mobs.Classes
{
    class BaseClass
    {
        #region BaseClass variables
        // Description / Misc
        ClassDescription m_classDescription { get; }
        
        // Primary ability
        int m_primaryAbility { get; set; }

        // Saving throws (can be multiple, and can be changed at a later stage)
        Proficiencies.SavingThrows.SavingThrows m_savingThrows { get; }

        // Hit points
        Dice.Dice m_dice { get; set; }

        // Proficiencies
        List<ProficiencyBools> m_armorProficiencies { get; set; }
        List<ProficiencyBools> m_weaponProficiencies { get; set; }
        List<ProficiencyBools> m_toolProficiencies { get; set; }

        // Skills
        List<Skill> m_skills { get; set; }
        #endregion

        public BaseClass(ClassDescription classDescription, int primaryAbility, Proficiencies.SavingThrows.SavingThrows savingThrows, Dice.Dice dice, List<ProficiencyBools> armorProficiencies, List<ProficiencyBools> weaponProficiencies, List<ProficiencyBools> toolProficiencies, List<Skill> skills)
        {
            #region set input data to local values

            m_classDescription = classDescription;
            m_primaryAbility = primaryAbility;
            m_savingThrows = savingThrows;
            m_dice = dice;
            m_armorProficiencies = armorProficiencies;
            m_weaponProficiencies = weaponProficiencies;
            m_toolProficiencies = toolProficiencies;
            m_skills = skills;

            #endregion
        }

        //Equipment

    }
}

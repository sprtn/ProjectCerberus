using System.Collections.Generic;
using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;
using ToolLibrary.Dungeons.Race.RacialTraits;
using ToolLibrary.Dungeons.Dice;
using ToolLibrary.Dungeons.Mobs.Classes;

namespace ToolLibrary.Dungeons.Mobs.PlayerCharacter
{
    class PlayerCharacter
    {
        DungeonsRace race;
        BaseClass baseClass;

        public PlayerCharacter()
        {
            #region create a blank race.
            race = new DungeonsRace(
            "",
            new List<Abilities.AbilityModifier>(),
            new Race.Helpers.AverageMeasurement(
                "",
                "",
                0d,
                0d
                ),
            new Race.Helpers.AverageMeasurement(
                "",
                "",
                0d,
                0d
                ),
            new CreatureSize()
            );
            #endregion

            #region create a blank base class
            baseClass = new BaseClass(
                classDescription: new ClassDescription(
                    "",
                    ""
                    ),
                primaryAbility: 0,
                savingThrows: null,
                dice: new Dice.Dice(""),
                armorProficiencies: new List<ProficiencyBools>(),
                toolProficiencies: new List<ProficiencyBools>(),
                skills: new List<Skills.Skill>(),
                weaponProficiencies: new List<ProficiencyBools>()
                );
            #endregion
        }
    }
}

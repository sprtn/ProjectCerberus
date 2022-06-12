using System.Collections.Generic;
using Shared.Dungeons.Mobs.Classes;
using Shared.Dungeons.Proficiencies.BaseProficiencyClass;

namespace Shared.Dungeons.Characters.Classes
{
    public class DungeonRace
    {


        public string RaceName { get; }
        private BaseClass _baseClass;
        public bool IsOriginalRace { get; }

        private void SetupDungeonClass(string className)
        {
            //_baseClass = new BaseClass(
            //    classDescription: new ClassDescription(
            //        "",
            //        ""
            //    ),
            //    primaryAbility: 0,
            //    savingThrows: null,
            //    dice: new Dice.Dice(""),
            //    armorProficiencies: new List<ProficiencyBools>(),
            //    toolProficiencies: new List<ProficiencyBools>(),
            //    skills: new List<Skills.Skill>(),
            //    weaponProficiencies: new List<ProficiencyBools>()
            //);
        }

        public DungeonRace(string raceName, bool isOriginalRace, BaseClass baseClass)
        {
            RaceName = raceName;
            IsOriginalRace = isOriginalRace;
            _baseClass = baseClass;
        }

        public DungeonRace(string raceName, bool isOriginalRace)
        {
            RaceName = raceName;
            IsOriginalRace = isOriginalRace;
            SetupDungeonClass(raceName);
        }

        public DungeonRace(string raceName)
        {
            RaceName = raceName;
            IsOriginalRace = false;
            SetupDungeonClass(raceName);
        }
    }
}
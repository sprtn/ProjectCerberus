using System.Collections.Generic;
using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;

namespace ToolLibrary.Dungeons.Mobs.Classes
{
    public class DungeonRace
    {
        public string ClassName { get; }
        private BaseClass _baseClass;
        public bool IsOriginalClass { get; }

        private void SetupDungeonClass(string className)
        {
            _baseClass = new BaseClass(
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
        }

        public DungeonRace(string className, bool isOriginalClass)
        {
            ClassName = className;
            IsOriginalClass = isOriginalClass;
            SetupDungeonClass(className);
        }

        public DungeonRace(string className)
        {
            ClassName = className;
            IsOriginalClass = false;
            SetupDungeonClass(className);
        }
    }
}
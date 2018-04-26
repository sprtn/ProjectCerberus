using System.Collections.Generic;
using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;
using ToolLibrary.Dungeons.Race.RacialTraits;
using ToolLibrary.Dungeons.Dice;
using ToolLibrary.Dungeons.Mobs.Classes;
using Calc = ToolLibrary.Maths.Calculator;

namespace ToolLibrary.Dungeons.Mobs.PlayerCharacter
{
    public class PlayerCharacter
    {
        public DungeonsRace Race;
        public DungeonClass Class;

        public int Height { get; set; }

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

            #region create a Class
            Class = new DungeonClass("Human");
            #endregion
        }

        /// <summary>
        /// This method sets the PC's Height variable to a 
        /// random double within the parameters of the race's
        /// lowest and highest allowed height.
        /// </summary>
        public void SetRandomHeight(DungeonsRace race)
        {
            Height = Calc.GetRandomNumber(
                (int)race.AverageHeight.AverageLow,
                (int)race.AverageHeight.AverageHigh);
        }
    }
}

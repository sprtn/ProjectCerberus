using ToolLibrary.Dungeons.Race.RacialTraits;
using ToolLibrary.Dungeons.Mobs.Classes;
using Calc = ToolLibrary.Maths.Calculator;

namespace ToolLibrary.Dungeons.Mobs.PlayerCharacter
{
    public class PlayerCharacter
    {
        public DungeonsRace Races;
        public DungeonRace Race;

        public int Height { get; set; }

        public PlayerCharacter()
        {
            #region create a Race
            Race = new DungeonRace("Human");
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

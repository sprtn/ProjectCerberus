using Shared.Dungeons.Characters.Classes;
using Shared.Dungeons.Race.RacialTraits;
using Shared.Dungeons.Mobs.Classes;
using Calc = Shared.Helpers.Calculator;
using DungeonRace = Shared.Dungeons.Characters.Race.SizeModifiers.DungeonRace;

namespace Shared.Dungeons.Mobs.PlayerCharacter
{
    public class PlayerCharacter
    {
        public DungeonsRace Races;
        public DungeonRace Race;

        public int Height { get; set; }

        public PlayerCharacter()
        {
            //DefaultRace = new DungeonRace("Human");
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

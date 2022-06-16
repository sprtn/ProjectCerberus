using System.Collections.Generic;
using Shared.Dungeons.Abilities;
using Shared.Dungeons.Race.Helpers;

namespace Shared.Dungeons.Race.RacialTraits
{
    public class DungeonsRace
    {
        public string RaceName;
        public List<AbilityModifier> RacialAbilityModifiers;
        public AverageMeasurement AverageHeight;
        public AverageMeasurement AverageWeight;
        public CreatureSize CreatureSize;

        public DungeonsRace(string raceName, List<AbilityModifier> racialAbilityModifiers, AverageMeasurement averageHeight, AverageMeasurement averageWeight, CreatureSize creatureSize)
        {
            RaceName = raceName;
            RacialAbilityModifiers = racialAbilityModifiers;
            AverageHeight = averageHeight;
            AverageWeight = averageWeight;
            CreatureSize = creatureSize;
        }
    }
}
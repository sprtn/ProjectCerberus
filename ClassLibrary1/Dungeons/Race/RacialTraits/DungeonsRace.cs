using System.Collections.Generic;
using ToolLibrary.Dungeons.Abilities;
using ToolLibrary.Dungeons.Race.Helpers;

namespace ToolLibrary.Dungeons.Race.RacialTraits
{
    internal class DungeonsRace
    {
        public string MRaceName;
        public List<AbilityModifier> MRacialAbilityModifiers;
        public AverageMeasurement MAverageHeight;
        public AverageMeasurement MAverageWeight;
        public CreatureSize MCreatureSize;

        public DungeonsRace(string mRaceName, List<AbilityModifier> mRacialAbilityModifiers, AverageMeasurement mAverageHeight, AverageMeasurement mAverageWeight, CreatureSize mCreatureSize)
        {
            MRaceName = mRaceName;
            MRacialAbilityModifiers = mRacialAbilityModifiers;
            MAverageHeight = mAverageHeight;
            MAverageWeight = mAverageWeight;
            MCreatureSize = mCreatureSize;
        }
    }
}
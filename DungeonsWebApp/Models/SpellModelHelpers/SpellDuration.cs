using DungeonsWebApp.Models.SpellModelHelpers.Enums;

namespace DungeonsWebApp.Models.SpellModelHelpers
{
    public class SpellDuration
    {
        public Helpers.DurationType DurationType { get; }
        public int DurationLength { get; }

        public SpellDuration(Helpers.DurationType durationType, int durationLength)
        {
            DurationType = durationType;
            DurationLength = durationLength;
        }
    }
}

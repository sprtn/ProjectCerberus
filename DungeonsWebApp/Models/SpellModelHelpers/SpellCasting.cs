using DungeonsWebApp.Models.SpellModelHelpers.Enums;

namespace DungeonsWebApp.Models.SpellModelHelpers
{
    public class SpellCasting
    {
        public Helpers.CastTimeType CastTimeType;
        public int CastTime;

        public Helpers.CastRangeType CastRangeType;
        public int CastRange;

        public SpellCasting(Helpers.CastTimeType castTimeType, int castTime,
            Helpers.CastRangeType castRangeType, int castRange)
        {
            CastTimeType = castTimeType;
            CastTime = castTime;

            CastRangeType = castRangeType;
            CastRange = castRange;
        }
    }
}

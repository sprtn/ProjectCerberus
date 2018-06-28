namespace DungeonsWebApp.Models.SpellModelHelpers.Enums
{
    public class Helpers
    {
        public enum Class
        {
            Barbarian = 0,
            Bard,
            Druid,
            Monk,
            Paladin,
            Ranger,
            Sorcerer,
            Warlock
        }

        public enum DurationType
        {
            Turn = 6,
            Minute = Turn * 10,
            Hour = Minute * 60,
            Day = Hour * 24,
            Week = Day * 7,
            Month = Week * 4,
            Year = Month * 12
        }

        public enum CastTimeType
        {
            Instantanous,
            StandardAction,
            BonusAction,
        }

        public enum CastRangeType
        {
            Feet,
            Meter,
            Mile,
            Kilometer,
        }
    }
}
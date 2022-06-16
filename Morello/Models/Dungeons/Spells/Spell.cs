using Morello.Dungeons.Spells.Classes;
using Morello.Dungeons.Spells.SpellSchool;

namespace Morello.Dungeons.Spells
{
    public class Spell
    {
        //General Spell Info
        public string name { get; }
        public string description { get; }
        public SpellSchoolEnum school { get; }

        //Duration
        public string durationType { get; }
        public int durationLength { get; }

        //Casting Time
        public string castTimeType { get; }
        public int castTimeLength { get; }

        //Casting Range
        public string castRangeType { get; }
        public int castRange { get; }

        //Higher level invocation
        public List<int> atWhatLevels { get; }
        public string atHigherLevelDescription { get; }

        //List of classes
        public ClassList classList { get; }

        //Component Requirements
        public SpellComponents components { get; }

        public Spell(string spellName, string spellDescription, SpellSchoolEnum spellSchool, string durationType, int durationLength, string castTimeType, int castTimeLength, string castRangeType, int castRangeLength, List<int> atWhatLevels, string atHigherLevelDescription, ClassList classList, SpellComponents spellComponents)
        {
            this.name = spellName;
            description = spellDescription;
            school = spellSchool;
            this.durationType = durationType;
            this.durationLength = durationLength;
            this.castTimeType = castTimeType;
            this.castTimeLength = castTimeLength;
            this.castRangeType = castRangeType;
            castRange = castRangeLength;
            this.atWhatLevels = atWhatLevels;
            this.atHigherLevelDescription = atHigherLevelDescription;
            this.classList = classList;
            components = spellComponents;
        }

        public override string ToString()
        {
            return $"{name}, {description} is a {school} type spell. {castRange}{castRangeType} cast range, cast time {castTimeType}";
        }
    }
}

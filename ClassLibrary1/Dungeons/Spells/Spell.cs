using System.Collections.Generic;
using Shared.Dungeons.Spells.Classes;

namespace Shared.Dungeons.Spells
{
    public class Spell
    {
        //General Spell Info
        public string m_spellName { get; }
        public string m_spellDescription { get; }
        public string m_spellSchool { get; }

        //Duration
        public string m_durationType { get; }
        public int m_durationLength { get; }

        //Casting Time
        public string m_castTimeType { get; }
        public int m_castTimeLength { get; }

        //Casting Range
        public string m_castRangeType { get; }
        public int m_castRangeLength { get; }

        //Higher level invocation
        public List<int> m_atWhatLevels { get; }
        public string m_atHigherLevelDescription { get; }

        //List of classes
        public ClassList m_classList { get; }

        //Component Requirements
        public SpellComponents m_spellComponents { get; }

        public Spell(string spellName, string spellDescription, string spellSchool, string durationType, int durationLength, string castTimeType, int castTimeLength, string castRangeType, int castRangeLength, List<int> atWhatLevels, string atHigherLevelDescription, ClassList classList, SpellComponents spellComponents)
        {
            m_spellName = spellName;
            m_spellDescription = spellDescription;
            m_spellSchool = spellSchool;
            m_durationType = durationType;
            m_durationLength = durationLength;
            m_castTimeType = castTimeType;
            m_castTimeLength = castTimeLength;
            m_castRangeType = castRangeType;
            m_castRangeLength = castRangeLength;
            m_atWhatLevels = atWhatLevels;
            m_atHigherLevelDescription = atHigherLevelDescription;
            m_classList = classList;
            m_spellComponents = spellComponents;
        }
    }
}

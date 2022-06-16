namespace Morello.Dungeons.Spells.SpellSchools
{
    public class SpellSchools : List<SpellSchoolInfo>
    {
        public SpellSchools GetSpellSchools() => this;

        public SpellSchools()
        {
            foreach (List<string> s in _schoolsInfoList)
                Add(new SpellSchoolInfo(s[0], s[1], s[2]));
        }

        private readonly List<List<string>> _schoolsInfoList = new List<List<string>>() // This needs to come from the DB later.
        {
            new List<string> {"Abjuration", "Blocking, banishing, protecting", "Abjurer"},
            new List<string> {"Conjuration", "Producing things/creatures out of thin air", "Conjurer"},
            new List<string> {"Divination", "Understanding the past, present and future", "Diviner"},
            new List<string> {"Enchantment", "Entrancing and beguiling people/creatures", "Enchanter"},
            new List<string> {"Evocation", "Harnessing the power of the elements", "Evoker"},
            new List<string> {"Illusion", "Deception and trickery", "Illusionist"},
            new List<string> {"Necromancy", "Dealing with life, death and undeath", "Necromancer"},
            new List<string> {"Transmutation", "Changing energy and matter", "Transmutater"},
        };
    }
}

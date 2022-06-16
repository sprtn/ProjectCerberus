using System.Collections.Generic;

namespace Morello.Dungeons.Spells.SpellSchool
{
    public class SpellSchools : List<SpellSchool>
    {
        public SpellSchools()
        { }

        public (SpellSchoolEnum, string, string) GetSpellSchoolInformation(SpellSchoolEnum spellSchoolEnum) => _schoolsInfoList.Find(s => s.Item1 == spellSchoolEnum);

        public readonly List<(SpellSchoolEnum, string, string)> _schoolsInfoList = new() // This needs to come from the DB later.
        {
            (SpellSchoolEnum.Abjuration, "Blocking, banishing, protecting", "Abjurer"),
            (SpellSchoolEnum.Conjuration, "Producing things/creatures out of thin air", "Conjurer"),
            (SpellSchoolEnum.Divination, "Understanding the past, present and future", "Diviner"),
            (SpellSchoolEnum.Enchantment, "Entrancing and beguiling people/creatures", "Enchanter"),
            (SpellSchoolEnum.Evocation, "Harnessing the power of the elements", "Evoker"),
            (SpellSchoolEnum.Illusion, "Deception and trickery", "Illusionist"),
            (SpellSchoolEnum.Necromancy, "Dealing with life, death and undeath", "Necromancer"),
            (SpellSchoolEnum.Transmutation, "Changing energy and matter", "Transmutater")
        };
    }
}

using DungeonsWebApp.Models.SpellModelHelpers;

namespace DungeonsWebApp.Models
{
    public class SpellModel
    {
        public SpellInfo SpellInfo;
        public SpellDuration SpellDuration;
        public SpellCasting SpellCasting;
        public SpellAscension SpellAscension;
        public SpellComponents SpellComponents;

        public SpellModel(SpellInfo spellInfo, SpellDuration spellDuration, SpellCasting spellCasting, SpellAscension spellAscension, SpellComponents spellComponents)
        {
            SpellInfo = spellInfo;
            SpellDuration = spellDuration;
            SpellCasting = spellCasting;
            SpellAscension = spellAscension;
            SpellComponents = spellComponents;
        }
    }
}

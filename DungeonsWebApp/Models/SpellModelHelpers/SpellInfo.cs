namespace DungeonsWebApp.Models.SpellModelHelpers
{
    public class SpellInfo
    {
        public string SpellName { get; }
        public string SpellDescription { get; }
        public string SpellSchool { get; }

        public SpellInfo(string spellName, string spellDescription, string spellSchool)
        {
            SpellName = spellName;
            SpellDescription = spellDescription;
            SpellSchool = spellSchool;
        }
    }
}

namespace Morello.Dungeons.Spells.SpellSchools
{
    public class SpellSchoolInfo
    {
        public string Name;
        public string Emphasis;
        public string MemberName;

        public SpellSchoolInfo GetSpellSchool() => this;

        public SpellSchoolInfo(string name, string emphasis, string memberName)
        {
            Name = name;
            Emphasis = emphasis;
            MemberName = memberName;
        }
    }
}

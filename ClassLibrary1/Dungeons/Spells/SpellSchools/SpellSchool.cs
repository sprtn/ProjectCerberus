namespace Morello.Dungeons.Spells.SpellSchool
{
    public class SpellSchool
    {
        public string Name;
        public string Emphasis;
        public string MemberName;

        public SpellSchool GetSpellSchool() => this;

        public SpellSchool(string name, string emphasis, string memberName)
        {
            Name = name;
            Emphasis = emphasis;
            MemberName = memberName;
        }
    }
}

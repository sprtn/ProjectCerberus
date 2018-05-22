namespace ToolLibrary.Dungeons.Spells
{
    public class SpellSchool
    {
        public readonly string Name;
        public readonly string Emphasis;
        public readonly string MemberName;

        public SpellSchool(string name, string emphasis, string memberName)
        {
            Name = name;
            Emphasis = emphasis;
            MemberName = memberName;
        }
    }
}

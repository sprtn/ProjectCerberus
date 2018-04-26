namespace ToolLibrary.Dungeons.Mobs.Classes
{
    public class ClassDescription
    {
        public string Name { get; }
        public string Description { get; }

        public ClassDescription(string name, string description)
        {
            Description = description;
            Name = name;
        }
    }
}
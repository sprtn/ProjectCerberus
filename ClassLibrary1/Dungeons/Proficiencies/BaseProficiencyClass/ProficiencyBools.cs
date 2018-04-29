namespace ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass
{
    public class ProficiencyBools
    {
        public string Title { get; set; }
        public int AbilityModifier;
        public bool HasProficiency { get; set; }
        public string Description { get; set; }

        public ProficiencyBools(string title, bool hasProficiency, int abilityModifier, string description)
        {
            Title = title;
            HasProficiency = hasProficiency;
            AbilityModifier = abilityModifier;
            Description = description;
        }
    }
}

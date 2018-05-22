using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;

namespace ToolLibrary.Dungeons.Skills
{
    public class Skill : ProficiencyBools
    {
        public Skill(string title, bool hasProficiency, int abilityModifier, string description) : base(title, hasProficiency, abilityModifier, description)
        {
            Title = title;
            HasProficiency = hasProficiency;
            AbilityModifier = abilityModifier;
            Description = description;
        }
    }
}

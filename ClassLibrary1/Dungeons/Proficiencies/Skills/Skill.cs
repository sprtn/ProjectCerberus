using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;

namespace ToolLibrary.Dungeons.Skills
{
    public class Skill : ProficiencyBools
    {
        public Skill(string title, bool hasProficiency, int abilityModifier, string description) : base(title, hasProficiency, abilityModifier, description)
        {
            m_title = title;
            m_hasProficiency = hasProficiency;
            m_abilityModifier = abilityModifier;
            m_description = description;
        }
    }
}

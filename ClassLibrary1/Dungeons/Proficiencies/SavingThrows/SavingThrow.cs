using ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass;

namespace ToolLibrary.Dungeons.SavingThrows
{
    public class SavingThrow : ProficiencyBools
    {
        public SavingThrow(string title, bool hasProficiency, int abilityModifier, string description) : base(title, hasProficiency, abilityModifier, description)
        {
            m_title = title;
            m_hasProficiency = hasProficiency;
            m_abilityModifier = abilityModifier;
            m_description = description;
        }
    }
}
namespace ToolLibrary.Dungeons.Proficiencies.BaseProficiencyClass
{
    public class ProficiencyBools
    {
        public string m_title { get; set; }
        public int m_abilityModifier;
        public bool m_hasProficiency { get; set; }
        public string m_description { get; set; }

        public ProficiencyBools(string title, bool hasProficiency, int abilityModifier, string description)
        {
            m_title = title;
            m_hasProficiency = hasProficiency;
            m_abilityModifier = abilityModifier;
            m_description = description;
        }
    }
}

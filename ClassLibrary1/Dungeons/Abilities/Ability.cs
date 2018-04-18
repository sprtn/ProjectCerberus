namespace ToolLibrary.Dungeons.Abilities
{
    public class Ability
    {
        public string GetTitle()
        {
            return m_title;
        }

        public int GetAbilityScore()
        {
            return m_abilityScore;
        }

        public void SetAbilityScore(int newAbilityScore)
        {
            m_abilityScore = newAbilityScore;
        }

        public int GetAbilityModifier()
        {
            if (m_abilityScore >= 10)
                return (m_abilityScore - 10) / 2;
            return ((m_abilityScore - 11) / 2);
        }

        private string m_title { get; }
        private int m_abilityScore { get; set; }

        public Ability(string title, int abilityScore)
        {
            m_title = title;
            m_abilityScore = abilityScore;
        }
    }
}

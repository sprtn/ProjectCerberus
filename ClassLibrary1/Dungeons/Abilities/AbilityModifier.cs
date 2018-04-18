namespace ToolLibrary.Dungeons.Abilities
{
    public class AbilityModifier
    {
        public int m_abilityMod;
        public string m_abilityName;

        public AbilityModifier(int abilityMod, string abilityName)
        {
            m_abilityMod = abilityMod;
            m_abilityName = abilityName;
        }
    }
}
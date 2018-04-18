namespace ToolLibrary.Dungeons.Spells
{
    internal class SpellComponents
    {
        public bool m_verbal;
        public bool m_somatic;
        public bool m_material;
        public string m_materialDescription;

        public SpellComponents(bool verbal, bool somatic, bool material, string materialDescription)
        {
            m_verbal = verbal;
            m_somatic = somatic;
            m_material = material;
            if (material)
                m_materialDescription = materialDescription;
            else
                m_materialDescription = "This spell requires no material components.";
        }
    }
}
namespace Shared.Dungeons.Spells
{
    public class SpellComponents
    {
        public bool Verbal;
        public bool Somatic;
        public bool Material;
        public string MaterialDescription;

        public SpellComponents(bool verbal, bool somatic, bool material, string materialDescription)
        {
            Verbal = verbal;
            Somatic = somatic;
            Material = material;
            MaterialDescription = material ? materialDescription : "This spell requires no material components.";
        }
    }
}
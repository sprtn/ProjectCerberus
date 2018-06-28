namespace DungeonsWebApp.Models.SpellModelHelpers
{
    public class SpellComponents
    {
        public bool Verbal;
        public bool Somatic;
        public bool Material;
        public string MaterialDescription;

        public SpellComponents(string materialDescription, bool verbal = false, bool somatic = false, bool material = false)
        {
            Verbal = verbal;
            Somatic = somatic;
            Material = material;
            MaterialDescription = material ? materialDescription : "No material requirements.";
        }
    }
}
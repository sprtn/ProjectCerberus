using System.Collections.Generic;
using System.Windows.Forms;
using ToolLibrary.Dungeons.Race.RacialTraits;
using ToolLibrary.FileHandlers.Local;

namespace Spellcraft
{
    public partial class SpellcraftForm : Form
    {
        public SpellcraftForm()
        {
            InitializeComponent();
            ExecuteStartup();
        }

        private void ExecuteStartup()
        {
            PopulateDefaults();
        }

        private void PopulateDefaults()
        {
            _description = string.Empty;
            races = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DungeonsRace>>(FileReader.ReadFile("Races"));
        }

        private string _description;
        private List<DungeonsRace> races;
    }
}

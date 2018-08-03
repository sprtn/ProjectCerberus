using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToolLibrary.Dungeons.Race;
using ToolLibrary.Dungeons.Race.RacialTraits;
using ToolLibrary.FileHandlers;
using ToolLibrary.FileHandlers.Local;
using ToolLibrary.FileHandlers.Logger;

namespace Spellcraft
{
    public partial class SpellcraftForm : Form
    {
        public JsonLogger JLogger = new JsonLogger();

        public SpellcraftForm()
        {
            InitializeComponent();
            ExecuteStartup();
        }

        private void ExecuteStartup()
        {
            FileHandlersCfg.GenerateFolders();
            PopulateDefaults();
        }

        private void PopulateDefaults()
        {
            PopulateRaces();
        }

        private void PopulateRaces()
        {
            try
            {
                Races = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DefaultRace>>(FileReader.ReadFile(FileHandlersCfg.FilePathRacesFile));
            }
            catch (Exception e)
            {
                JLogger.LogError(e);
                JLogger.LogDebug("Races could not be found. Creating new default Races file.");
            }

            if (Races != null)
                if (Races.Any())
                    return;

            Races = new ListOfDefaultRaces();

            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(Races);

            FileWriter.WriteFile(FileHandlersCfg.FilePathRacesFile, jsonString);
        }

        private string _description;
        public List<DefaultRace> Races;
    }
}

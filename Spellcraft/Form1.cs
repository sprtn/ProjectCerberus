using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Shared.Dungeons.Race;
using Shared.FileHandlers;
using Shared.FileHandlers.Local;
using Shared.FileHandlers.Logger;

namespace Spellcraft
{
    public partial class SpellcraftForm : Form
    {
        public JsonLogger JLogger = new JsonLogger();
        public List<DefaultRace> Races;

        private string _description;
        private int _durationTime = 1;
        private DurationType _durationType = DurationType.Minute;

        private string GetDurationString() =>
            $"{(_durationType == DurationType.Special || _durationType == DurationType.Instantaneous ? string.Empty : $"{_durationTime} ")}{_durationType.ToString()}{GetDurationSuffix(_durationTime, _durationType)}";

        private string GetDurationSuffix(int durationTime, DurationType durationType)
        {
            if (durationTime == 1 || durationType == DurationType.Special || durationType == DurationType.Instantaneous)
                return "";

            switch (durationType.ToString().ToCharArray().LastOrDefault())
            {
                case 's':
                    return "'";
                default:
                    return "s";
            }
        }

        enum DurationType
        {
            Instantaneous,
            Round,
            Minute,
            Hour,
            Day,
            Special
        }

        enum CastingDuration
        {
            Action,
            Bonus_Action,
            Reaction,
            Minute,
            Hour
        }

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
            //PopulateDurationTypes();
            //SetDefaultDurationVariables();
            SetDurationString();
        }

        //private void SetDefaultDurationVariables()
        //{
        //    DurationTypeCombobox.Text = _durationType.ToString();
        //    DurationUpDown.Value = _durationTime;
        //}

        //private void PopulateDurationTypes()
        //{
        //    DurationTypeCombobox.Items.AddRange(new []
        //    {
        //        DurationType.Instantaneous.ToString(),
        //        DurationType.Round.ToString(),
        //        DurationType.Minute.ToString(),
        //        DurationType.Hour.ToString(),
        //        DurationType.Day.ToString(),
        //        DurationType.Special.ToString()
        //    });
        //}

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

        private void materialCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            MaterialTextbox.Enabled = MaterialCheckbox.Checked;

            if (!MaterialTextbox.Enabled)
                MaterialTextbox.Text = "";
        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            DescriptionCheckBox.Checked = DescriptionTextbox.Text.Length > 5;

            if (!DescriptionTextbox.Enabled)
                DescriptionTextbox.Text = "";
        }

        private void NameTextbox_DoubleClick(object sender, EventArgs e)
        {
            NameTextbox.Text = "";
        }

        private void DurationUpDown_ValueChanged(object sender, EventArgs e)
        {
            _durationTime = (int) DurationUpDown.Value;
            SetDurationString();
        }

        private void DurationTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _durationType = (DurationType) DurationTypeCombobox.SelectedIndex;
            SetDurationString();
        }

        private void SetDurationString()
        {
            DurationLabel.Text = GetDurationString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ToolLibrary.Dungeons.Mobs.Classes;
using ToolLibrary.Dungeons.Spells;
using ToolLibrary.Dungeons.Spells.SpellSchools;

namespace Book_of_Spells
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DungeonClasses _dungeonClasses;
        private SpellSchools _spellSchoolsss;

        public MainWindow()
        {
            InitializeComponent();
            InitializeSpellbookVariables();
        }

        private void InitializeSpellbookVariables()
        {
            _dungeonClasses = new DungeonClasses();
            _spellSchoolsss = new SpellSchools();

            //var ssd = spellschoolCombo;

            //ssd.ItemsSource = ss;
            //ssd.DisplayMemberPath = "Name";
            //ssd.SelectedValuePath = "Name";
            //ssd.SelectedValue = "{Binding Path=ToolLibrary.Dungeons.Spells.SpellSchools.SpellSchool}";
        }

        private void NextSpellcraftingTabControlTab(object sender, RoutedEventArgs e)
        {
            ChangeTabIndex(SpellcraftingTabControl, true);
        }

        private void PreviousSpellcraftingTabControlTab(object sender, RoutedEventArgs e)
        {
            ChangeTabIndex(SpellcraftingTabControl, false);
        }

        private void ChangeTabIndex(TabControl tab, bool increment)
        {
            var curIndex = tab.SelectedIndex;
            if (curIndex == 0 && !increment)
                return;
            tab.SelectedIndex = increment ? curIndex + 1 : curIndex - 1;
        }

        private void spellNameInput_LostFocus(object sender, RoutedEventArgs e)
        {
            WriteOverInformationOnFocusLoss(spellName, spellNameInput);
        }

        private static void WriteOverInformationOnFocusLoss(Label receiver, object sender)
        {
            switch (sender.GetType().ToString())
            {
                case ("System.Windows.Controls.TextBox"):
                    receiver.Content = ((TextBox)sender).Text;
                    break;
                case ("System.Windows.Controls.ContentControl"):
                    receiver.Content = ((ContentControl)sender).Content;
                    break;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            CheckboxOnContent(descriptionCheckbox, spellDescriptionInput);
        }

        private void CheckboxOnContent(CheckBox checkBox, TextBox textBox)
        {
            checkBox.IsChecked = textBox.Text != "";
        }

        private void SetCorrespondingCheckboxValue(object sender, RoutedEventArgs e)
        {
            if (sender.GetType().ToString() != "System.Windows.Controls.CheckBox" && 
                sender.GetType().ToString() != "System.Windows.Controls.Primitives.ToggleButton")
                return;
            var box = (CheckBox) sender;
            if (box.IsChecked == null)
                return;
            switch (box.Name)
            {
                case ("verbalCheckbox"):
                    topVCheckbox.IsChecked = box.IsChecked;
                    break;
                case ("somaticCheckbox"):
                    topSCheckbox.IsChecked = box.IsChecked;
                    break;
                case ("materialCheckbox"):
                    topMCheckbox.IsChecked = box.IsChecked;
                    break;
            }
        }
    }
}

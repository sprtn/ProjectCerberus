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
        private DungeonClasses dc;
        private SpellSchools ss;

        public MainWindow()
        {
            InitializeComponent();
            InitializeSpellbookVariables();
        }

        private void InitializeSpellbookVariables()
        {
            dc = new DungeonClasses();
            ss = new SpellSchools();

            var ssd = spellSchoolDropdown;

            ssd.ItemsSource = ss;
            ssd.DisplayMemberPath = "Name";
            ssd.SelectedValuePath = "Name";
            ssd.SelectedValue = "{Binding Path=ToolLibrary.Dungeons.Spells.SpellSchools.SpellSchool}";

            //ssd.DataContext = ss;
            //ssd.Items.Refresh();
            //foreach (SpellSchool s in ss)
            //    ssd.Items.Add(s);


            //var dcc = dungeonClassesCheckboxDataGridList;
            //dcc.DataContext = dc;
            //foreach (DungeonClass d in dc)
            //    dcc.Items.Add(d);

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

        private void WriteOverInformationOnFocusLoss(Label receiver, object sender)
        {
            var type = sender.GetType().ToString();

            switch (type)
            {
                case ("System.Windows.Controls.TextBox"):
                    receiver.Content = ((TextBox)sender).Text;
                    break;
                default:
                    receiver.Content = "Default: " + type;
                    Console.WriteLine("Could not recognize type:" + type);
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
            if (sender.GetType().ToString() != "System.Windows.Controls.CheckBox")
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
                default:
                    Console.WriteLine(box.Name);
                    break;
            }
        }
    }
}

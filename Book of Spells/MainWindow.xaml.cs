﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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

        #region Tab control, tab selection manager
        private void ChangeTabIndex(Selector tab, bool increment)
        {
            var curIndex = tab.SelectedIndex;
            if (curIndex == 0 && !increment)
                return;
            tab.SelectedIndex = increment ? curIndex + 1 : curIndex - 1;
        }
        #endregion

        #region Information from sender to receiverCheckBox
        private static void SenderToReceiverManager(Label receiver, object sender)
        {
            var text = string.Empty;
            switch (sender.GetType().ToString())
            {
                case ("System.Windows.Controls.TextBox"):
                    text = ((TextBox) sender).Text;
                    break;
                case ("System.Windows.Controls.ContentControl"):
                    text = ((ContentControl) sender).Content.ToString();
                    break;
            }
            receiver.Content = string.IsNullOrEmpty(text) ? "Nameless spell" : text;
        }
        #endregion

        #region events
        private void spellNameInput_LostFocus(object sender, RoutedEventArgs e)
        {
            SenderToReceiverManager(spellName, spellNameInput);
        }

        private void NextSpellcraftingTabControlTab(object sender, RoutedEventArgs e)
        {
            ChangeTabIndex(SpellcraftingTabControl, true);
        }

        private void PreviousSpellcraftingTabControlTab(object sender, RoutedEventArgs e)
        {
            ChangeTabIndex(SpellcraftingTabControl, false);
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            SetCheckedTo(descriptionCheckbox, spellDescriptionInput);
        }
        #endregion

        #region Checkbox setters
        private void SetCorrespondingCheckboxValue(object sender, RoutedEventArgs e)
        {
            if (sender.GetType().ToString() != "System.Windows.Controls.CheckBox" &&
                sender.GetType().ToString() != "System.Windows.Controls.Primitives.ToggleButton")
                return;
            var box = (CheckBox)sender;
            if (box.IsChecked == null)
                return;
            switch (box.Name)
            {
                case ("verbalCheckbox"):
                    SetCheckedTo(topVCheckbox, box);
                    break;
                case ("somaticCheckbox"):
                    SetCheckedTo(topSCheckbox, box);
                    break;
                case ("materialCheckbox"):
                    SetCheckedTo(topMCheckbox, box);
                    break;
            }
        }

        private void SetCheckedTo(CheckBox receiverCheckBox, object senderObject)
        {
            switch (senderObject.GetType().ToString())
            {
                case ("System.Windows.Controls.TextBox"):
                    receiverCheckBox.IsChecked = ((TextBox)senderObject).Text != "";
                    break;
                case ("System.Windows.Controls.CheckBox"):
                    receiverCheckBox.IsChecked = ((CheckBox) senderObject).IsChecked;
                    break;
            }
        }
        #endregion
    }
}

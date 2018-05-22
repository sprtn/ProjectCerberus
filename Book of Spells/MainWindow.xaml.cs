using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToolLibrary.Dungeons.Mobs.Classes;
using ToolLibrary.Dungeons.Spells;

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
            dc = new DungeonClasses();
            ss = new SpellSchools();
            InitializeComponent();
            //InitializeDungeonClasses();
        }

        private void InitializeDungeonClasses()
        {
            //dc = new DungeonClasses();
            //var dcc = dungeonClassesCheckboxDataGridList;
            //dcc.DataContext = dc;
            //foreach (var c in dc)
            //{
            //    dcc.Items.Add(c);
            //}

            //dcc.RowHeight = 25;
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
    }
}

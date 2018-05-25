using System.Collections.Generic;
using ToolLibrary.Dungeons.Spells.Classes;

namespace TestRunner.Tests
{
    public class ClassTests
    {
        public string CurrentTest;
        public List<bool> TestResults = new List<bool>();

        public bool TestClassList()
        {
            CurrentTest = "Test Race List";

            var classList = new ClassList(new List<string>
            {
                "Barbarian",
                "Emo",
                "Monk"
            });

            // Test class functionality

            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using ToolLibrary.Dungeons.Abilities;

namespace TestRunner.Tests
{
    public class AbilityTests
    {
        public string CurrentTest;
        public List<bool> TestResults = new List<bool>();

        public bool TestAbilityReturn()
        {
            CurrentTest = "Testing ability return";
            TestResults.Clear();

            try
            {
                AbilityTest(new Ability("test", 10), "test", 10, 0, true);
                AbilityTest(new Ability("Strength", 8), "Strength", 8, -1, true);
                AbilityTest(new Ability("Dexterity", 14), "Dexterity", 14, 2, true);
                AbilityTest(new Ability("Con", 19), "Con", 19, 5, false);
                AbilityTest(new Ability("low", 3), "low", 3, -4, true);
                AbilityTest(new Ability("thing", 4), "thing", 4, -4, false);
                AbilityTest(new Ability("thing", 4), "thing", 4, -4, false);
                AbilityTest(new Ability("thing", 4), "thing", 4, -4, false);
                AbilityTest(new Ability("thing", 4), "thing", 4, 3, false);

                return !TestResults.Contains(false);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Whoops: {e.Message}");
                return false;
            }
        }
        
        private void AbilityTest(Ability ability, string correctTitle, int correctAbilityScore, int correctModifier, bool modifierShouldReturnTrue)
        {
            // Test correct title.
            TestResults.Add(ability.GetTitle() != null && ability.GetTitle() == correctTitle ? 
                true : false);

            // Test correct ability score.
            TestResults.Add(ability.GetAbilityScore() == correctAbilityScore ?
                true : false );

            // Test correct ability modifiers
            TestResults.Add(ability.GetAbilityModifier() == correctModifier ?
                modifierShouldReturnTrue : !modifierShouldReturnTrue);
        }
    }
}

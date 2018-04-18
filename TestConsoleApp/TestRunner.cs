using System;
using TestRunner.Tests;

namespace TestRunner
{
    class TestRunner
    {
        static int m_testNumber = 0;

        static void Main(string[] args)
        {
            // Define test classes
            var abilityTests = new AbilityTests();
            var classTests = new ClassTests();
            var diceTests = new DiceTests();

            // Run tests
            RunTest(diceTests.FirstDiceTest(), diceTests.CurrentTest);
            RunTest(classTests.TestClassList(), classTests.CurrentTest);
            RunTest(abilityTests.TestAbilityReturn(), abilityTests.CurrentTest);

            Console.ReadKey();
        }

        // Simple method for running test and printing result etc. to Console
        private static void RunTest(bool testResult, string testName)
        {
            Console.WriteLine($"Test: {testName}, " +
                $"Success: {testResult.ToString()}, " +
                $"Test Number: {m_testNumber++}");
        }
    }
}

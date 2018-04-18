using System;
using System.Threading.Tasks.Dataflow;
using TestRunner.Tests;

namespace TestRunner
{
    internal class TestRunner
    {
        private static int _testNumber = 1;

        private static void Main(string[] args)
        {
            // Define test classes
            var abilityTests = new AbilityTests();
            var classTests = new ClassTests();
            var diceTests = new DiceTests();

            // Run tests
            RunTest(diceTests.FirstDiceTest(), diceTests.CurrentTest);
            RunTest(diceTests.SecondDiceTest(), diceTests.CurrentTest);
            RunTest(classTests.TestClassList(), classTests.CurrentTest);
            RunTest(abilityTests.TestAbilityReturn(), abilityTests.CurrentTest);

            Console.ReadKey();
        }

        // Simple method for running test and printing result etc. to Console
        private static void RunTest(bool testResult, string testName)
        {
            LineBreak();
            Write($"Test: {testName}");
            Write($"Success: {testResult}");
            Write($"Test Number: {_testNumber++}");
            LineBreak();
        }

        private static void LineBreak()
        {
            Write("");
            Write("--");
            Write("");
        }

        public static void Write(string input)
        {
            Console.WriteLine(input);
        }
    }
}

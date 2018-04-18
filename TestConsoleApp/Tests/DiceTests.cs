using System;
using System.Collections.Generic;

using ToolLibrary.Dungeons.Dice;

namespace TestRunner.Tests
{
    class DiceTests
    {
        public string CurrentTest { get; internal set; }

        // Having issues on this test. Haven't got to testing the adh-test.
        public bool FirstDiceTest()
        {
            CurrentTest = "First Dice Test";

            List<Dice> listOfTestDice = new List<Dice>()
            {
                new Dice("2d2"),
                new Dice("3d2"),
                new Dice("6d6"),
                new Dice("adh")
            };

            foreach (var dice in listOfTestDice)
            {
                try
                {
                    Console.WriteLine($"testing dice {dice.ToString()}");
                    int totalForAllTests = 0;
                    int numberOfTests = 10;

                    for (int i = 0; i < numberOfTests; i++)
                        totalForAllTests += dice.ThrowDice();

                    if (totalForAllTests > numberOfTests * (dice.GetNumberOfDice * dice.GetSizeOfDice) ||
                        totalForAllTests < numberOfTests)
                        return false;
                }
                catch(Exception e)
                {
                    if (dice.ToString() != "adh")
                    {
                        Console.WriteLine($"Error occured at dice test of {dice.ToString()} ", e.Message);
                        return false;
                    }
                    else
                        Console.WriteLine("First Dice Test succeeded");
                }
            }
            return true;
        }
    }
}

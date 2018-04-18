using System;
using System.Collections.Generic;

using ToolLibrary.Dungeons.Dice;

namespace TestRunner.Tests
{
    internal class DiceTests
    {
        public string CurrentTest { get; internal set; }
        
        /// <summary>
        /// Simple test that runs predetermined dice.
        /// </summary>
        /// <returns>Success or failure</returns>
        public bool FirstDiceTest()
        {
            
            SetTest("First dice test");

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
                    Console.WriteLine("First Dice Test succeeded");
                }
            }
            return true;
        }

        /// <summary>
        /// A more advanced test where the tester supplies the dice input.
        /// </summary>
        /// <returns>Success unless exception</returns>
        public bool SecondDiceTest()
        {
            SetTest("Second dice test");

            try
            {
                #region Variable declarations

                var first = true;
                var cont = true;
                var x = 0;
                var y = 0;

                #endregion

                Console.WriteLine("Please insert two int's to simulate Dice numbers.");
                Console.WriteLine("The first integer will simulate the number of die");
                Console.WriteLine("The second will determine the number of eyes on the die.");

                while (cont)
                {
                    var key = Console.ReadKey();
                    Console.WriteLine();
                    if (key.Key == ConsoleKey.Escape)
                        cont = false;
                    
                    if (first)
                        if (int.TryParse(key.KeyChar.ToString(), out x))
                            first = false;
                        else
                            Console.WriteLine($"Could not parse {key.KeyChar}. Please write in the first number or press esc to exit.");
                    else if (int.TryParse(key.KeyChar.ToString(), out y))
                    {
                        first = true;

                        Console.WriteLine($"Dice {x}d{y} is being throwed. Result: {new Dice($"{x}d{y}").ThrowDice()}");
                        Console.WriteLine("Press Esc to end the test. Write in two new integers to throw again.");
                    }
                }
                Console.WriteLine("Ending Second dice test.");

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private void SetTest(string input)
        {
            CurrentTest = input;
        }
    }
}

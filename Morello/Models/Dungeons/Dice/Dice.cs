using System;
using Calc = Shared.Helpers.Calculator;
//using SC = System.Console;

namespace Shared.Dungeons.Dice
{
    public class Dice
    {
        public int DiceSize { get; } = 6;

        public int DiceQuantity { get; } = 1;

        /// <summary>
        /// Constructor for the Dice class
        /// </summary>
        /// <param name="diceName">Takes a string containing int + char + int as a string, Ex: 1d4.</param>
        public Dice(string diceName)
        {
            if (diceName.Length != 3)
                return;

            var diceNameAsCharArray = diceName.ToCharArray();

            if (int.TryParse(diceNameAsCharArray[0].ToString(), out var numberOfDice) &&
                int.TryParse(diceNameAsCharArray[2].ToString(), out var sizeOfDice))
            {
                DiceQuantity = numberOfDice;
                DiceSize = sizeOfDice;
            }
            else
                throw new Exception($"Unable to parse dice. {diceNameAsCharArray[0]} and {diceNameAsCharArray[2]} should be integers. Example: 2d6");
        }
        public Dice(int diceSize, int numDice )
        {
            DiceSize = diceSize;
            DiceQuantity = numDice;
        }
        public Dice() { }

        #region ThrowDice methods with overloads.

        /// <summary>
        /// Throw the dice
        /// </summary>
        /// <returns>Throws the number of dice and returns the value</returns>
        public int ThrowDice()
        {
            var total = 0;
            for (var i = 0; i < DiceQuantity; i++)
                total += Calc.GetRandomNumber(1, DiceSize);

            return total;
        }

        /// <summary>
        /// Throw the dice with minimum value
        /// </summary>
        /// <param name="min">Minimum allowed value for each dice throw</param>
        /// <returns>Throws the number of dice and returns the value</returns>
        public int ThrowDice(int min)
        {
            var total = 0;
            for (var i = 0; i < DiceQuantity; i++)
                total += Calc.GetRandomNumber(min, DiceSize);

            return total;
        }

        /// <summary>
        /// Throw the dice with minimum and maximum value
        /// </summary>
        /// <param name="min">Minimum allowed value for each dice throw</param>
        /// <param name="max">Maximum allowed value for each dice throw</param>
        /// <returns></returns>
        public int ThrowDice(int min, int max)
        {
            var total = 0;
            for (var i = 0; i < DiceQuantity; i++)
            {
                var addedNumber = 0;
                var attempts = 0;

                //CodeRev: There's something off about this logic. Why do I never use addednumber?
                while (addedNumber <= min || addedNumber >= max || attempts > 10)
                {
                    addedNumber = Calc.GetRandomNumber(min, max);
                    attempts++;
                }

                if (attempts < 10)
                    total += Calc.GetRandomNumber(min, DiceSize);
                else
                    total += Calc.GetAverageNumber(min, max);
            }          

            return total;
        }
        #endregion

        /// <summary>
        /// Override of ToString
        /// </summary>
        /// <returns>Returns a string containing a number of dice + d + size of dice</returns>
        public override string ToString()
        {
            return $"{DiceQuantity}d{DiceSize}";
        }
    }
}
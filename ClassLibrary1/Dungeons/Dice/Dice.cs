using ToolLibrary.Maths;

namespace ToolLibrary.Dungeons.Dice
{
    public class Dice
    {
        private readonly string _mDiceName;

        public int GetSizeOfDice { get; }

        public int GetNumberOfDice { get; }


        public Dice(string diceName)
        {
            _mDiceName = diceName;

            #region If the dice is a 'xdy', we store x as numberOfDice and y as sizeOfDice

            if (diceName.Length != 3)
                return;

            var contains = diceName.ToCharArray();

            if (int.TryParse(contains[0].ToString(), out var numberOfDice) &&
                int.TryParse(contains[2].ToString(), out var sizeOfDice))
            {
                GetNumberOfDice = numberOfDice;
                GetSizeOfDice = sizeOfDice;
            }
            else
            {
                System.Console.WriteLine($"Tried to parse the dice {diceName} to no avail. Make sure {contains[0]} and {contains[2]} are integers.");
                GetSizeOfDice = 0;
                GetNumberOfDice = 0;
            }
            #endregion
        }

        #region ThrowDice methods with overloads.
        public int ThrowDice()
        {
            var total = 0;
            for (var i = 0; i < GetNumberOfDice; i++)
                total += Calculator.GetRandomNumber(1, GetSizeOfDice);
            
            return total;
        }

        public int ThrowDice(int min)
        {
            int total = 0;
            for (int i = 0; i < GetNumberOfDice; i++)
                total += Maths.Calculator.GetRandomNumber(min, GetSizeOfDice);

            return total;
        }

        public int ThrowDice(int min, int max)
        {
            int total = 0;
            for (int i = 0; i < GetNumberOfDice; i++)
            {
                int addedNumber = 0;
                int attempts = 0;

                while (addedNumber <= min || addedNumber >= max || attempts > 10)
                {
                    addedNumber = Calculator.GetRandomNumber(min, max);
                    attempts++;
                }

                if (attempts < 10)
                    total += Calculator.GetRandomNumber(min, GetSizeOfDice);
                else
                    total += Calculator.GetAverageNumber(min, max);
            }               

            return total;
        }
        #endregion

        public override string ToString()
        {
            return _mDiceName;
        }
    }
}
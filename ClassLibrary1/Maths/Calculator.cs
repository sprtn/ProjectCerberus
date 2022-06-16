using System;

namespace Shared.Helpers
{
    public static class Calculator
    {
        public static readonly Random Rnd = new();

        public static int GetRandomNumber(int min, int max)
        {
            lock (Rnd)
            {
                return Rnd.Next(min, max + 1);
            }
        }

        public static int GetAverageNumber(int min, int max)
        {
            return (min + max / 2);
        }
    }
}
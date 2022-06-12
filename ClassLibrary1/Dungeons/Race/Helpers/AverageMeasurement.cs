namespace Shared.Dungeons.Race.Helpers
{
    public class AverageMeasurement
    {
        // What is being measured
        public string Name;

        // Meters, feet, lbs, kg's
        public string MeansOfMeasurement;

        // The range between top and bottom measurement.
        public double AverageLow;
        public double AverageHigh;

        public AverageMeasurement(string name, string meansOfMeasurement, double averageLow, double averageHigh)
        {
            Name = name;
            MeansOfMeasurement = meansOfMeasurement;
            AverageLow = averageLow;
            AverageHigh = averageHigh;
        }
    }
}
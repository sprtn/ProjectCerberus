namespace ToolLibrary.Dungeons.Race.Helpers
{
    public class AverageMeasurement
    {
        // What is being measured
        public string m_name;

        // Meters, feet, lbs, kg's
        public string m_meansOfMeasurement;

        // The range between top and bottom measurement.
        public double m_averageLow;
        public double m_averageHigh;

        public AverageMeasurement(string name, string meansOfMeasurement, double averageLow, double averageHigh)
        {
            m_name = name;
            m_meansOfMeasurement = meansOfMeasurement;
            m_averageLow = averageLow;
            m_averageHigh = averageHigh;
        }
    }
}
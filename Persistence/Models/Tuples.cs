namespace Persistence.Models
{
    public class Tuples
    {

        public class OpeningHours
        {
            public string OpeningHour { get; set; }
            public string ClosingHour { get; set; }
        }

        public class DataPoint
        {
            public int xAxis { get; set; }
            public double yAxis { get; set; }
        }
    }
}
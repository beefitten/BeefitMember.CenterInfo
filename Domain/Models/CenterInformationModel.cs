using System.Collections.Generic;

namespace Domain.Models
{
    public class CenterInformationModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public List<(string, string)> OpeningHours { get; set; }
        public List<(string, string)> MannedHours { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<(int, double)> HeatMapDataPoints { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
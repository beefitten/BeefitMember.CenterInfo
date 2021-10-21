using System.Collections.Generic;

namespace Persistence.Models
{
    public record CenterInformationModel(
        string Name,
        string Location,
        List<(string, string)> OpeningHours,
        List<(string, string)> MannedHours,
        string Email,
        string PhoneNumber,
        List<(int, double)> HeatMapDataPoints,
        string Latitude,
        string Longitude
    );
}
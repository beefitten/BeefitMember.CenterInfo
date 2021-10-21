using System.Collections.Generic;

namespace Persistence.Models
{
    public record CenterInformationModel(
        string Name,
        string Location,
        List<Tuples.OpeningHours> OpeningHours,
        List<Tuples.OpeningHours> MannedHours,
        string Email,
        string PhoneNumber,
        List<Tuples.DataPoint> HeatMapDataPoints,
        string Latitude,
        string Longitude
    );
}
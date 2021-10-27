using System;
using System.Collections.Generic;

namespace Persistence.Models
{
    public record CenterInformationModel(
        string Name,
        string Location,
        List<Tuple<string, string>> OpeningHours,
        List<Tuple<string, string>> MannedHours,
        string Email,
        string PhoneNumber,
        List<Tuple<string, string>> HeatMapDataPoints,
        string Latitude,
        string Longitude
    );
}
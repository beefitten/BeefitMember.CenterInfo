using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Persistence.Models
{
    public class CenterInformationMongoModel
    {
        [BsonId]
        [BsonRequired]
        [BsonElement("Name")]
        public string Name { get; set; }
        
        [BsonRequired]
        [BsonElement("Location")]
        public string Location { get; set; }
        
        [BsonRequired]
        [BsonElement("OpeningHours")]
        public List<Tuple<string, string>> OpeningHours { get; set; }
        
        [BsonRequired]
        [BsonElement("MannedHours")]
        public List<Tuple<string, string>> MannedHours { get; set; }
        
        [BsonRequired]
        [BsonElement("Email")]
        public string Email { get; set; }
        
        [BsonRequired]
        [BsonElement("PhoneNumber")]
        public string PhoneNumber { get; set; }
        
        [BsonRequired]
        [BsonElement("HeatMapDataPoints")]
        public List<Tuple<string, string>> HeatMapDataPoints { get; set; }
        
        [BsonRequired]
        [BsonElement("Latitude")]
        public string Latitude { get; set; }
        
        [BsonRequired]
        [BsonElement("Longitude")]
        public string Longitude { get; set; }
    }
}
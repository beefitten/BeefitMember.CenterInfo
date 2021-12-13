using System;
using System.Net;
using System.Threading.Tasks;
using MongoDB.Driver;
using Persistence.Models;
using Persistence.Settings;

namespace Persistence.Repositories
{
    public class CenterInformationRepository : ICenterInformationRepository
    {
        private readonly IMongoCollection<CenterInformationMongoModel> _collection;
        
        public CenterInformationRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _collection = database.GetCollection<CenterInformationMongoModel>(settings.CollectionName);
        }
        
        public async Task<HttpStatusCode> AddCenterInformation(CenterInformationModel model)
        {
            if (model == null)
                return HttpStatusCode.Conflict;

            try
            {
                var modelToInsert = new CenterInformationMongoModel()
                {
                    Name = model.Name,
                    Location = model.Location,
                    OpeningHours = model.OpeningHours,
                    MannedHours = model.MannedHours,
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    HeatMapDataPoints = model.HeatMapDataPoints,
                    Latitude = model.Latitude,
                    Longitude = model.Longitude
                };

                await _collection.InsertOneAsync(modelToInsert);
                return HttpStatusCode.OK;
            }
            catch (Exception e)
            {
                return HttpStatusCode.Conflict;
            }
        }

        public async Task<CenterInformationModel> GetCenterInformation(string centerId)
        {
            if (centerId == null)
                throw new Exception("Invalid center id");

            var model = await _collection
                .Find<CenterInformationMongoModel>(x => x.Name == centerId)
                .FirstOrDefaultAsync();

            if (model == null)
                throw new Exception("No center was found");

            return new CenterInformationModel(
                model.Name,
                model.Location,
                model.OpeningHours,
                model.MannedHours,
                model.Email,
                model.PhoneNumber,
                model.HeatMapDataPoints,
                model.Latitude,
                model.Longitude);
        }
    }
}
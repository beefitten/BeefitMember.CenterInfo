using System.Net;
using System.Threading.Tasks;
using Persistence.Models;
using Persistence.Repositories;

namespace Domain.Services
{
    public class CenterInformationService : ICenterInformationService
    {
        private readonly ICenterInformationRepository _repository;

        public CenterInformationService(ICenterInformationRepository repository)
        {
            _repository = repository;
        }
        
        public async Task<HttpStatusCode> AddCenterInformation(CenterInformationModel model)
        {
            return await _repository.AddCenterInformation(model);
        }

        public async Task<CenterInformationModel> GetCenterInformation(string centerId)
        {
            return await _repository.GetCenterInformation(centerId);
        }
    }
}
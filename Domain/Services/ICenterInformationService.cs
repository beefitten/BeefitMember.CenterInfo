using System.Net;
using System.Threading.Tasks;
using Persistence.Models;

namespace Domain.Services
{
    public interface ICenterInformationService
    {
        Task<HttpStatusCode> AddCenterInformation(CenterInformationModel model);
        Task<CenterInformationModel> GetCenterInformation(string centerId);
    }
}
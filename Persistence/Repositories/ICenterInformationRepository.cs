using System.Net;
using System.Threading.Tasks;
using Persistence.Models;

namespace Persistence.Repositories
{
    public interface ICenterInformationRepository
    {
        Task<HttpStatusCode> AddCenterInformation(CenterInformationModel model);
        Task<CenterInformationModel> GetCenterInformation(string centerId);
    }
}
using System.Net;
using System.Threading.Tasks;
using Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Persistence.Models;

namespace RestAPI.Controllers
{
    [ApiController]
    [Route("CenterInformation")]
    public class CenterInformationController : Controller
    {
        private readonly ICenterInformationService _service;
        
        public CenterInformationController(ICenterInformationService service)
        {
            _service = service;
        }
        
        [HttpGet]
        [Route("/getCenterInformation/{centerName}")]
        public async Task<CenterInformationModel> GetCenterInformation(string centerName)
        { 
            return await _service.GetCenterInformation(centerName);
        }

        [HttpPost]
        [Route("/addCenterInformation")]
        public async Task<HttpStatusCode> AddCenterInformation(CenterInformationModel model)
        {
            return await _service.AddCenterInformation(model);
        }
    }
}
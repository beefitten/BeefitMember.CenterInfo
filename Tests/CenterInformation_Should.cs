using System.Net;
using System.Threading.Tasks;
using AutoFixture;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Models;
using Persistence.Repositories;
using RestAPI.Controllers;
using Shouldly;
using Xunit;

namespace Tests
{
    public class CenterInformation_Should
    {
        private readonly Fixture _fixture;
        private readonly CenterInformationController _controllers;
        private readonly ICenterInformationRepository _repository;
        public CenterInformation_Should()
        {
            _fixture = new Fixture();
            var testFixture = new TestFixture();
            _controllers = new CenterInformationController(testFixture.ServiceProvider.GetService<ICenterInformationService>());
            // _repository = te
        }

        [Fact]
        public async Task Return_Success_On_Create()
        {
            //Arrange
            var request = _fixture.Create<CenterInformationModel>();
     
            //Act
            var response = await _controllers.AddCenterInformation(request);
            
            //Assert
            Assert.Equal(HttpStatusCode.OK, response);
        }

        [Fact]
        public async Task Return_Correct_Name()
        {
            //Arrange
            var expected = _fixture.Create<CenterInformationModel>();
            await _controllers.AddCenterInformation(expected);

            //Act
            var response = await _controllers.GetCenterInformation(expected.Name);
            
            //Assert
            response.Name.ShouldBe(expected.Name);
        }

        [Fact]
        public async Task Return_Success_On_Create_Test()
        {
            //Arrange
            var request = _fixture.Create<CenterInformationModel>();

            //Act
            var response = await _controllers.AddCenterInformation(request);

            //Assert
            Assert.Equal(HttpStatusCode.OK, response);
        }
    }
}
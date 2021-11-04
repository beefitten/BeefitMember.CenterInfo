using Domain;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Setup;
using RestAPI;

namespace Tests
{
    public class TestFixture
    {
        public ServiceProvider ServiceProvider { get; }
        
        public TestFixture()
        {
            ServiceProvider = new ServiceCollection()
                .AddDomain()
                .AddRestAPI()
                .AddPersistence()
                .BuildServiceProvider();
        }
    }
}
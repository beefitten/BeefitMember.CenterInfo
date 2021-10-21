namespace Persistence.Settings
{
    public class CenterInformationSetup : IDatabaseSettings
    {
        public CenterInformationSetup()
        {
            CollectionName = "CenterInformation";
            ConnectionString = AppConfig.GetConnectionString();
            DatabaseName = "BeefitMember";
        }

        public string CollectionName { get; }
        public string ConnectionString { get; }
        public string DatabaseName { get; }
    }
}
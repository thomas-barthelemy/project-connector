using System.Threading.Tasks;
using Project_Connector.Models;

namespace Project_Connector.Connectors
{
    public abstract class PlatformConnector
    {
        public string Hostname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ApiKey { get; set; }

        protected PlatformConnector() { }
        protected PlatformConnector(string hostname, string apiKey)
        {
            Hostname = hostname;
            ApiKey = apiKey;
        }

        protected PlatformConnector(string hostname, string username, string password)
        {
            Hostname = hostname;
            Username = username;
            Password = password;
        }

        public abstract ProjectExchangeData Import();
        public abstract void Export(ProjectExchangeData data);

        public async virtual Task<ProjectExchangeData> ImportAsync()
        {
            return await Task.Run(() => Import());
        }

        public async virtual Task ExportAsync(ProjectExchangeData data)
        {
            await Task.Run(() => Export(data));
        }
    }
}

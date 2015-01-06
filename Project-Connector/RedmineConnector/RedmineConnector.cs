using System;
using Project_Connector.Connectors;
using Project_Connector.Models;
using Redmine.Net.Api;
using RedmineUser = Redmine.Net.Api.Types.User;
using RedmineProject = Redmine.Net.Api.Types.Project;
using RedmineIssue = Redmine.Net.Api.Types.Issue;

namespace RedmineConnector
{
    public class RedminePlatformConnector : PlatformConnector
    {
        private readonly RedmineManager _redmineManager;

        public RedminePlatformConnector(string hostname, string apiKey)
            : base(hostname, apiKey)
        {
            _redmineManager = new RedmineManager(Hostname, ApiKey, MimeFormat.xml, false);
        }


        public override ProjectExchangeData Import()
        {
            var redmineUsers = _redmineManager.GetTotalObjectList<RedmineUser>(null);
            var redmineProjects = _redmineManager.GetTotalObjectList<RedmineProject>(null);
            var redmineIssues = _redmineManager.GetTotalObjectList<RedmineIssue>(null);

            return null;
        }

        public override void Export(ProjectExchangeData data)
        {
            throw new NotImplementedException();
        }

        private User ToUser(RedmineUser redmineUser)
        {
            return new User
            {
                Id = redmineUser.Id.ToString(),
                Email = redmineUser.Email,
                Username = redmineUser.Login
            };
        }
    }
}

using System;
using System.Linq;
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

            var result = new ProjectExchangeData
            {
                ExportDate = DateTime.Now,
                ExportOrigin = new ExportOrigin {Name = "Redmine"},
                Version = "1.0",
                Users = redmineUsers.Select(ToUser),
                Projects = redmineProjects.Select(ToProject),
                Issues = redmineIssues.Select(ToIssue)
            };

            return result;
        }

        public override void Export(ProjectExchangeData data)
        {
            throw new NotImplementedException();
        }

        private static User ToUser(RedmineUser redmineUser)
        {
            return new User
            {
                Id = redmineUser.Id.ToString(),
                Email = redmineUser.Email,
                Username = redmineUser.Login
            };
        }

        private static Project ToProject(RedmineProject redmineProject)
        {
            var project = new Project
            {
                Id = redmineProject.Id.ToString(),
                CreationDate = redmineProject.CreatedOn,
                Description = redmineProject.Description,
                LastUpdate = redmineProject.UpdatedOn,
                Name = redmineProject.Name,
            };
            if (redmineProject.Parent != null)
                project.ParentId = redmineProject.Parent.Id.ToString();
            return project;
        }

        private static Issue ToIssue(RedmineIssue redmineIssue)
        {
            var issue = new Issue
            {
                Id = redmineIssue.Id.ToString(),
                AuthorId = redmineIssue.Author.Id.ToString(),
                Description = redmineIssue.Description,
                Title = redmineIssue.Subject,
                ProjectId = redmineIssue.Project.Id.ToString(),
                CreationDate = redmineIssue.CreatedOn,
                LastUpdate = redmineIssue.UpdatedOn,
                DueDate = redmineIssue.DueDate,
                AssigneeId = redmineIssue.AssignedTo.Id.ToString(),
            };
            if (redmineIssue.ParentIssue != null)
                issue.ParentId = redmineIssue.ParentIssue.Id.ToString();

            return issue;
        }
    }
}

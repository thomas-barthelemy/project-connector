using Project_Connector_Library.Models;

namespace Project_Connector_Library.Connectors
{
    public class PlatformConvertor
    {
        public virtual IssueType ToIssueType(string type)
        {
            if (type == null) return IssueType.Task;

            type = type.ToLower();

            if(type.Contains("story"))
                return IssueType.Story;
            if(type.Contains("bug"))
                return IssueType.Bug;

            return IssueType.Task;
        }

        public virtual IssueStatus ToIssueStatus(string status)
        {
            if (status == null) return IssueStatus.New;

            status = status.ToLower(); 

            if(status.Contains("progress"))
                return IssueStatus.InProgress;
            if(status.Contains("closed"))
                return IssueStatus.Closed;
            if(status.Contains("resolved"))
                return IssueStatus.Resolved;

            return IssueStatus.New;
        }
    }
}

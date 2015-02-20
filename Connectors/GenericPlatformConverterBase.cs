using System.Collections.Generic;
using Project_Connector_Library.Models;

namespace Project_Connector_Library.Connectors
{
    public abstract class GenericPlatformConverterBase
        <TUser, TProject, TIssue, TProjectMembership>
    {
        public abstract User ToUser(TUser user);
        public abstract TUser ToPlatformUser(User user);

        public abstract Project ToProject(
            TProject project,
            IEnumerable<TProjectMembership> projectMemberships);

        public abstract TProject ToPlatformProject(Project project);
        public abstract Issue ToIssue(TIssue issue);
        public abstract TIssue ToPlatformIssue(Issue issue);
    }
}
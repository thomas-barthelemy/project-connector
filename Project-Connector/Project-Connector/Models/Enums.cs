namespace Project_Connector.Models
{
    public enum IssueStatus
    {
        New = 0,
        InProgress = 1,
        Resolved = 2,
        Closed = 3
    }

    public enum IssueType
    {
        Task = 0,
        Bug = 1,
        Story = 2
    }
}
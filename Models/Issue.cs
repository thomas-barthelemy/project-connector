using System;
using System.Collections.Generic;

namespace Project_Connector_Library.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string AssigneeId { get; set; }
        public IssueStatus Status { get; set; }

        public string ParentId { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? DueDate { get; set; }
        public TimeSpan? TimeSpent { get; set; }
        public IssueType Type { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}

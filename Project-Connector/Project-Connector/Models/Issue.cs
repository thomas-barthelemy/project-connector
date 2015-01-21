using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Connector.Models
{
    public class Issue
    {
        [Required]
        public string Id { get; set; }
        [Required]
        public string ProjectId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AssigneeId { get; set; }
        [Required]
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

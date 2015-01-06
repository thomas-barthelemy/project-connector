using System;
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

        public string ParentId { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public DateTime? DueDate { get; set; }
    }
}

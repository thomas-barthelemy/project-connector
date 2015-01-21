using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Connector.Models
{
    public class Project
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Id { get; set; }
        public string Description { get; set; }
        public string ParentId { get; set; }
        public string AuthorId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public IEnumerable<ProjectMembership> Members { get; set; }
    }
}

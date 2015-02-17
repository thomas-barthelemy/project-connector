using System;
using System.Collections.Generic;

namespace Project_Connector_Library.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
        public string ParentId { get; set; }
        public string AuthorId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public IEnumerable<ProjectMembership> Members { get; set; }
    }
}

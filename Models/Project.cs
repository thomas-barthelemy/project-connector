using System;
using System.Collections.Generic;

namespace Project_Connector_Library.Models
{
    public class Project
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Identifier { get; set; }
        public string Description { get; set; }
        public int ParentId { get; set; }
        public int AuthorId { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdate { get; set; }
        public IEnumerable<ProjectMembership> Members { get; set; }
    }
}

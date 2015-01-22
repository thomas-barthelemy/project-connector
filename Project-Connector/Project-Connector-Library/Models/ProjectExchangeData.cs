using System;
using System.Collections.Generic;

namespace Project_Connector_Library.Models
{
    public class ProjectExchangeData
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Issue> Issues { get; set; }
        public IEnumerable<User> Users { get; set; }

        public string Version { get; set; }
        public DateTime? ExportDate { get; set; }
        public ExportOrigin ExportOrigin { get; set; }
    }
}

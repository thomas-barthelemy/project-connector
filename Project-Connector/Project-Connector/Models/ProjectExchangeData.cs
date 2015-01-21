using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Connector.Models
{
    public class ProjectExchangeData
    {
        [Required]
        public IEnumerable<Project> Projects { get; set; }
        [Required]
        public IEnumerable<Issue> Issues { get; set; }
        [Required]
        public IEnumerable<User> Users { get; set; }

        public string Version { get; set; }
        public DateTime? ExportDate { get; set; }
        public ExportOrigin ExportOrigin { get; set; }
    }
}

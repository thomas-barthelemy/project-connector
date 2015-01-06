using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Connector.Models
{
    public class ProjectExchangeData
    {
        [Required]
        public Project[] Projects { get; set; }
        [Required]
        public Issue[] Issues { get; set; }

        public string Version { get; set; }
        public DateTime? ExportDate { get; set; }
        public ExportOrigin ExportOrigin { get; set; }
    }
}

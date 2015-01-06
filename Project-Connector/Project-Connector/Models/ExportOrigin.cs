using System.ComponentModel.DataAnnotations;

namespace Project_Connector.Models
{
    public class ExportOrigin
    {
        [Required]
        public string Name { get; set; }
        public string Version { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Project_Connector.Models
{
    public class User
    {
        [Required]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}

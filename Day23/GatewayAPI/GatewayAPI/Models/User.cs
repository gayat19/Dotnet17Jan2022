using System.ComponentModel.DataAnnotations;

namespace GatewayAPI.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordHash { get; set; }
    }
}

using MessagePack;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleMVCTogetherApp.Models
{
    public class User
    {
        [System.ComponentModel.DataAnnotations.Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}

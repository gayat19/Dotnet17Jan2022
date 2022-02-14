using System.ComponentModel.DataAnnotations;

namespace SampleMVCTogetherApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Customer name cannot be empty")]
        public string Name { get; set; }
        [Range(18,55,ErrorMessage ="Invalid age")]
        public int Age { get; set; }
    }
}

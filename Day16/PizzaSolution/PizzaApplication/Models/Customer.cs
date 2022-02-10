using System.ComponentModel.DataAnnotations;

namespace PizzaApplication.Models
{
    public class Customer
    {
        [Key]
        public string Phone { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

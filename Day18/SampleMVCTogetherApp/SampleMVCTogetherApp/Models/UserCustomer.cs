using System.ComponentModel.DataAnnotations;

namespace SampleMVCTogetherApp.Models
{
    public class UserCustomer
    {
        public string Username { get; set; }
        public string Password { get; set; }
        [Display(Name ="Re-Type Password")]
        [Compare("Password", ErrorMessage ="Password Mismatch")]
        public string RePassword { get; set; }
        public string Role { get; set; }

        //public int CustomerId { get; set; }
        [Display(Name="Customer Name")]
        public string Name { get; set; }
        [Range(18, 55, ErrorMessage = "Invalid age")]
        public int Age { get; set; }
        public override string ToString()
        {
            return Username + " " + Password + " " + Name+" "+Role;
        }
    }
}

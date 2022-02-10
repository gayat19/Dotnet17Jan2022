namespace PizzaApplication.Models
{
    public class Pizza 
    {
        public int PizzaID { get; set; }
        public string Name { get; set; }
        public bool IsVeg { get; set; }
        public double Price { get; set; }
        public string Pic { get; set; }
        public string Details { get; set; }
    }
}

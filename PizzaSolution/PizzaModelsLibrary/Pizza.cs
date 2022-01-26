using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelsLibrary
{
    public class Pizza // :IComparable
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVeg { get; set; }
        public double Price { get; set; }

        //public int CompareTo(object obj)
        //{
        //    Pizza p1, p2;
        //    p1 = this;
        //    p2 = (Pizza)obj;
        //    return p1.Price.CompareTo(p2.Price);
        //}
        public void GetPizzaDetails()
        {
            Console.WriteLine("Please enter the pizza name");
            Name = Console.ReadLine();
            Console.WriteLine("IS the pizza veg? true/false");
            bool isVeg;
            while (!bool.TryParse(Console.ReadLine(),out isVeg))
            {
                Console.WriteLine("Invalid entry for isveg. Please try again...");
            }
            IsVeg = isVeg;
            Console.WriteLine("Please enter the pizza's price");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid entry for price. Please try again...");
            }
            Price = price;
        }
        public override string ToString()
        {
            return "Pizza ID " + Id
                + "\nPizza Name " + Name
                + "\nPizza Is Veg? " + IsVeg
                + "\nPizza Price " + Price;
        }
    }
}

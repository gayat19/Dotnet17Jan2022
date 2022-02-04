using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDALEFLibrary;

namespace PizzaFEConsoleApp
{
    internal class ManageCart
    {
        public void PrintCart()
        {
            Console.WriteLine("Enter teh customer number");
            int id = Convert.ToInt32(Console.ReadLine());
            CartDAL cart = new CartDAL();
            cart.GetCart(id);

        }
    }
}

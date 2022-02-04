using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModelsLibrary;

namespace PizzaDALEFLibrary
{
    public class CartDAL
    {
        readonly PizzaContext _pizzaContext;
        public CartDAL()
        {
            _pizzaContext = new PizzaContext();
        }
        public void GetCart(int cid)
        {
            var crtDetails = _pizzaContext.CartsPizzas
                        .Include(c=>c.Pizza)
                        .Include(c=>c.Cart)
                        .Include(c=>c.Cart.Customer).Where(c=>c.Cart.CustomerNumber==cid).ToList();


            Console.WriteLine("The cart number " + crtDetails[0].CartNumber);
            Console.WriteLine("The cart number " + crtDetails[0].Cart.Customer.Name);
            foreach (var item in crtDetails)
            {
                Console.WriteLine("                  " + item.Pizza.Name);
                Console.WriteLine("                  " + item.Pizza.Price);
                if (item.Pizza.IsVeg)
                    Console.WriteLine("                  Veg");
                else
                    Console.WriteLine("                  Non-Veg");
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}

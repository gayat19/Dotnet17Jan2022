using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModelsLibrary;

namespace PizzaFEConsoleApp
{
    internal class ManageMenu
    {
        Pizza[] pizzas = new Pizza[3];

        public void AddPizzas()
        {
            for (int i = 0; i < pizzas.Length; i++)
            {
                pizzas[i] = new Pizza();
                pizzas[i].GetPizzaDetails();
            }
        }
        public Pizza GetPizzaById(int id)
        {
            Pizza pizza = null;
            for (int i = 0; i < pizzas.Length; i++)
            {
                if(pizzas[i].Id==id)
                    pizza = pizzas[i];
            }
            return pizza;
        }
        public void EditPizzaPrice()
        {
            Console.WriteLine("Please enter the pizza id");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry ID. Please try again...");
            }
            Pizza pizza = GetPizzaById(id);
            if(pizza == null)
            {
                Console.WriteLine("Invalid Id. Cannot edit");
                return;
            }
            double price;
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid entry for price. Please try again...");
            }
            pizza.Price = price;
        }
        
    }
}

using PizzaModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALEFLibrary
{
    public class PizzaDAL
    {
        readonly PizzaContext _pizzaContext;
        public PizzaDAL()
        {
           _pizzaContext = new PizzaContext();
        }
        /// <summary>
        /// Gets all the records from teh table in the Pizza database
        /// </summary>
        /// <returns>
        ///      ICollection&lt;Pizza&gt;
        /// </returns>
        /// <exception cref="NoPizzaException"></exception>
        public ICollection<Pizza> GetAllPizzas()
        {
            List<Pizza> pizzas =_pizzaContext.Pizzas.ToList();
            if (pizzas.Count == 0)
                throw new NoPizzaException();
            return pizzas;
        }
        public bool InsertNewPizza(Pizza pizza)
        {
           _pizzaContext.Pizzas.Add(pizza);
            _pizzaContext.SaveChanges();
            return true;
        }
        public bool UpdatePizzaPrice(int id, float price)
        {
            Pizza pizza = _pizzaContext.Pizzas.SingleOrDefault(p=>p.Id == id);
            if (pizza == null)
                return false;
            pizza.Price = price;
            _pizzaContext.SaveChanges();
            return true;
        }
    }
}

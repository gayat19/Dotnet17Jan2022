using PizzaApplication.Models;

namespace PizzaApplication.Services
{
    public class PizzaRepo : IRepo<int, Pizza>
    {
        static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                PizzaID = 1,
                Name ="HHH",
                IsVeg = true,
                Price = 12.4,
                Pic = "/images/Pizza1.jpg",
                Details = "a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients (such as anchovies, mushrooms, onions, olives, pineapple, meat, etc.),"
            },
             new Pizza()
            {
                PizzaID = 2,
                Name ="PLI",
                IsVeg = false,
                Price = 45.7,
                Pic = "/images/Pizza2.jpg",
                Details = "a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients (such as anchovies, mushrooms, onions, olives, pineapple, meat, etc.),"
            }
        };
        public bool Add(Pizza t)
        {
            Pizzas.Add(t);
            return true;
        }

        public bool Delete(int k)
        {
            try
            {
                Pizzas.Remove(Pizzas.Find(p => p.PizzaID == k));
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public ICollection<Pizza> GetAll()
        {
            return Pizzas;
        }

        public Pizza GetT(int k)
        {
            var pizza = Pizzas.FirstOrDefault(p => p.PizzaID == k);
            return pizza;
        }

        public bool Update(int k, Pizza t)
        {
            var MyPizza = Pizzas.FirstOrDefault(p => p.PizzaID == k);
            if(MyPizza != null)
            {
                MyPizza.Name = t.Name;
                MyPizza.Price = t.Price;
                MyPizza.IsVeg = t.IsVeg;
                MyPizza.Details = t.Details;
                return true;
            }
           return false;
        }
    }
}

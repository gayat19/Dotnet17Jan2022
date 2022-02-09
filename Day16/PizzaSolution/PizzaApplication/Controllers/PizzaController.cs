using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;

namespace PizzaApplication.Controllers
{
    public class PizzaController : Controller
    {
        static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                PizzaID = 1,
                Name ="ABC",
                IsVeg = true,
                Price = 12.4
            },
             new Pizza()
            {
                PizzaID = 2,
                Name ="BBB",
                IsVeg = false,
                Price = 45.7
            }
        };
        public IActionResult Index()
        {
            var pizzas = Pizzas;
            return View(pizzas);
        }
        [HttpGet]
        public IActionResult Create()
        {
            
            return View(new Pizza());
        }
        [HttpPost]
        //public IActionResult Create(IFormCollection keyValues)
        //{
        //    Pizza pizza = new Pizza();
        //    pizza.Id = Convert.ToInt32(keyValues["id"].ToString());
        //    pizza.Name = keyValues["name"].ToString();
        //    pizza.Price = Convert.ToDouble(keyValues["price"].ToString());
        //    //pizza.IsVeg = keyValues["isVeg"].checked;
        //    Pizzas.Add(pizza);
        //    return RedirectToAction("Index");
        //}
        public IActionResult Create(Pizza pizza)
        {
            Pizzas.Add(pizza);
            return RedirectToAction("Index");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using PizzaDALEFLibrary;
using PizzaModelsLibrary;
using PizzaWebApp.Models;

namespace PizzaWebApp.Controllers
{
    public class PizzaController : Controller
    {
        List<FEPizza> Pizzas = new List<FEPizza>()
        {
            new FEPizza()
            {
                Id = 1,
                Name ="ABC",
                IsVeg = true,
                Price = 12.4
            },
             new FEPizza()
            {
                Id = 2,
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
    }
}

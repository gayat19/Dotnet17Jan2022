using EmptyWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Waffle()
        {
            Toppings toppings = new Toppings();
            toppings.Syrup = "Mapple";
            toppings.Sprinkles = "Choco chips";
            //ViewBag.Toppings = toppings;
            return View(toppings);
            //return View();
        }
        public string Rice()
        {
            return "Steaming hot rice";
        }

    }
}

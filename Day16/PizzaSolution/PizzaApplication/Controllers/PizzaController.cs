using Microsoft.AspNetCore.Mvc;
using PizzaApplication.Models;
using PizzaApplication.Services;

namespace PizzaApplication.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IRepo<int, Pizza> _repo;

        public PizzaController(IRepo<int,Pizza> repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var pizzas = _repo.GetAll();
            return View(pizzas);
        }
        public IActionResult Details(int id)
        {
            var pizza = _repo.GetT(id);
            return View(pizza);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var pizza = _repo.GetT(id);
            return View(pizza);
        }
        [HttpPost]
        public IActionResult Edit(int id,Pizza pizza)
        {
            _repo.Update(id, pizza);
            return RedirectToAction("Index");
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
            _repo.Add(pizza);
            return RedirectToAction("Index");
        }
    }
}

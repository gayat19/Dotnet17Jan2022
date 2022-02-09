using Microsoft.AspNetCore.Mvc;

namespace UsingTemplate.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

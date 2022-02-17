using FirstAPI.Models;
using FirstAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]//Attribute based routing
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepo<int, Customer> _repo;

        public CustomerController(IRepo<int,Customer> repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            List<Customer> customers = _repo.GetAll().ToList();
            if (customers.Count == 0)
                return BadRequest("No customers found");
            return Ok(customers);
        }

        [HttpGet]
        [Route("SingleEmployee")]
        public ActionResult<Customer> Get(int id)
        {
            var customer = _repo.GetT(id);
            if(customer == null)
                return NotFound();
            return Ok(customer);
        }
        [HttpPut]
        public ActionResult<Customer> Put(int id,Customer cust)
        {
            var customer= _repo.Update(cust);
            if(customer!=null)
            {
                return Created("Updated",customer);
            }
            return NotFound();

        }
        [HttpDelete]
        public ActionResult<Customer> Delete(int id)
        {
            var customer = _repo.Delete(id);
            if (customer != null)
            {
                return NoContent();
            }
            return NotFound(customer);
        }
        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            var cust = _repo.Add(customer);
            if (cust != null)
            {
                return Created("Customer Created",cust);
            }
            return BadRequest("Unable to create");
        }
    }
}

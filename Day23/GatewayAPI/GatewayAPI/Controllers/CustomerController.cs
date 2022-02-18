using GatewayAPI.Models;
using GatewayAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GatewayAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        private readonly IRepo<int, Customer> _repo;

        public CustomerController(IRepo<int, Customer> repo)
        {
            _repo = repo;
        }
        [Route("GetAllCustomers")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> IndexAsync()
        {
            var customers = await _repo.GetAll();
            return Ok(customers.ToList());
        }

       [Route("GetCustomer")]
        [HttpGet]
        public async Task<ActionResult<Customer>> Details(int id)
        {
            var customer = await _repo.Get(id);
            if (customer == null)
                return BadRequest("No such Customer");
            return Ok(customer);
        }

      
        // POST: CustomerController/Create
        [HttpPost]
        public async Task<ActionResult<Customer>> Create(Customer customer)
        {
            
            var cust = await _repo.Add(customer);
            if(cust == null)
                return NotFound();
            return Created("CUstomer created",customer);
           
        }

        [HttpPut]
        public async Task<ActionResult<Customer>> Edit(int id, Customer customer)
        {
            var cust = await _repo.Update(customer);
            if (cust == null)
                return NotFound();
            return Ok(customer);
        }

      [HttpDelete]
        public async Task<ActionResult<Customer>> Delete(int id)
        {
            var cust = await _repo.Delete(id);
            if (cust == null)
                return NotFound();
            return Ok(cust);
        }
    }
}

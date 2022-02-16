using FirstAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]//Attribute based routing
    [ApiController]
    public class CustomerController : ControllerBase
    {
        static List<Customer> _customers = new List<Customer>
        { new Customer { Id = 1, Name ="Tim",Age=23},
            new Customer { Id =2, Name ="Jim",Age=33},
            new Customer { Id = 3, Name ="Lim",Age=29}
        };
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customers;
        }

        [HttpGet]
        [Route("SingleEmployee")]
        public Customer Get(int id)
        {
            return _customers.SingleOrDefault(c=>c.Id == id);
        }
        [HttpPut]
        public Customer Put(int id,Customer cust)
        {
            var customer= _customers.SingleOrDefault(c => c.Id == id);
            if(customer!=null)
            {
                customer.Name = cust.Name;
                customer.Age = cust.Age;
            }
            return customer;        
        }
        [HttpDelete]
        public Customer Delete(int id)
        {
            var customer = _customers.IndexOf(_customers.Find(c=>c.Id==id));
            if (customer != -1)
            {
                _customers.RemoveAt(customer);
                return _customers.SingleOrDefault(c => c.Id == id);
            }
            return null;
        }
        [HttpPost]
        public Customer Post(Customer customer)
        {
           _customers.Add(customer);
            return customer;
        }
    }
}

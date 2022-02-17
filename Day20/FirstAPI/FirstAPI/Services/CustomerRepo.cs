using FirstAPI.Models;

namespace FirstAPI.Services
{
    public class CustomerRepo : IRepo<int, Customer>
    {
        private readonly ShopContext _context;

        public CustomerRepo(ShopContext context)
        {
            _context = context;
        }
        public Customer Add(Customer item)
        {
           _context.Customers.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Customer Delete(int key)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == key);
            if(customer != null)
            {
                _context.Remove(customer);
                _context.SaveChanges();
            }
            return customer;

        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public Customer GetT(int key)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == key);
            return customer;
        }

        public Customer Update(Customer item)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == item.Id);
            if (customer != null)
            {
                customer.Name = item.Name;
                customer.Age = item.Age;    
                _context.SaveChanges();
            }
            return customer;
        }
    }
}

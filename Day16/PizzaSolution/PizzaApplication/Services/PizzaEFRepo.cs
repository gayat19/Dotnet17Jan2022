using PizzaApplication.Models;

namespace PizzaApplication.Services
{
    public class PizzaEFRepo : IRepo<int, Pizza>
    {
        private readonly PizzaShopContext _context;

        public PizzaEFRepo(PizzaShopContext context)
        {
            _context = context;
        }
        public bool Add(Pizza t)
        {
            _context.Pizzas.Add(t);
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int k)
        {

            _context.Pizzas.Remove(GetT(k));
            _context.SaveChanges();
            return true;
        }

        public ICollection<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }

        public Pizza GetT(int k)
        {
            return _context.Pizzas.FirstOrDefault(p=>p.PizzaID == k);
        }

        public bool Update(int k, Pizza t)
        {
            var MyPizza = _context.Pizzas.FirstOrDefault(p => p.PizzaID == k);
            if (MyPizza != null)
            {
                MyPizza.Name = t.Name;
                MyPizza.Price = t.Price;
                MyPizza.IsVeg = t.IsVeg;
                MyPizza.Details = t.Details;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

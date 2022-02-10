using Microsoft.EntityFrameworkCore;

namespace PizzaApplication.Models
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza()
                {
                    PizzaID = 101,
                    Name = "ABC",
                    IsVeg = true,
                    Price = 12.4,
                    Pic = "/images/Pizza1.jpg",
                    Details = "a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients (such as anchovies, mushrooms, onions, olives, pineapple, meat, etc.),"
                },
                 new Pizza()
                 {
                     PizzaID = 102,
                     Name = "BBB",
                     IsVeg = false,
                     Price = 45.7,
                     Pic = "/images/Pizza2.jpg",
                     Details = "a dish of Italian origin consisting of a usually round, flat base of leavened wheat-based dough topped with tomatoes, cheese, and often various other ingredients (such as anchovies, mushrooms, onions, olives, pineapple, meat, etc.),"
                 }
            );
        }
    }
}

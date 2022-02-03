using PizzaModelsLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALEFLibrary
{
    internal class PizzaContext : DbContext
    {

        public PizzaContext():base("conn")
        {

        }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartPizzas> CartsPizzas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartPizzas>().HasKey(cp => new{ cp.PizzaId,cp.CartNumber});
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 101, Name = "Tim", Age = 23 },
             new Customer { Id = 102, Name = "Jim", Age = 33 },
             new Customer { Id = 103, Name = "Lim", Age = 29 });
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace SampleMVCTogetherApp.Models
{
    public class ShopContext :DbContext
    {
        public ShopContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer() { Id = 101, Name = "Tim", Age = 23 },
                new Customer() { Id = 102, Name = "Jim", Age = 31 }
                );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using eTicaret.Domain.Entities;

namespace ETicaret.Persistance.Contexts {
    public class ETicaretDBContext : DbContext {

        public ETicaretDBContext(DbContextOptions option) : base(option) {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}

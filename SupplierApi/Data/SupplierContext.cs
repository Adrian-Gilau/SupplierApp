using Microsoft.EntityFrameworkCore;
using SupplierApi.Entities;

namespace SupplierApi.Data
{
    public class SupplierContext : DbContext
    {
        public SupplierContext(DbContextOptions<SupplierContext> options) : base(options) { }

        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>()
                .HasKey(s => s.Code);
        }

    }
}

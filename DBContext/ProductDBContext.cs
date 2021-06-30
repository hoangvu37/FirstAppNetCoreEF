
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using netcoreapi.Models;

namespace netcoreapi.DBContext
{
    public class ProductDBContext: DbContext
    {
        
        public ProductDBContext(DbContextOptions<ProductDBContext> options): base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductCategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDetailtEntityConfiguration());
            modelBuilder.ApplyConfiguration(new SupplierEntityConfiguration());
        }
        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                SaveChanges();
                _transaction.Commit();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.EntityConfiguration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(p => p.Name)
                    .IsRequired()
                    .IsUnicode(true)
                    .HasMaxLength(256);

            builder.HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierID);

            builder.HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierID);

            builder.HasOne(p => p.ProductDetail)
                .WithOne(s => s.Product)
                .HasForeignKey<ProductDetail>(p => p.ProductID);

            builder.HasData(
                new Product
                {
                    ID = 1,
                    Description = "Descriptions",
                    Name = "Product 1",
                    Price = 100,
                    Rating = 1,
                    DiscontinuedDate = DateTime.Now,
                    ReleaseDate = DateTime.Now,
                    SupplierID = 1
                },
                new Product
                {
                    ID = 2,
                    Description = "Descriptions",
                    Name = "Product 2",
                    Price = 100,
                    Rating = 1,
                    DiscontinuedDate = DateTime.Now,
                    ReleaseDate = DateTime.Now,
                    SupplierID = 1
                }
                ,
                new Product
                {
                    ID = 3,
                    Description = "Descriptions 3",
                    Name = "Product 3 ",
                    Price = 100,
                    Rating = 1,
                    DiscontinuedDate = DateTime.Now,
                    ReleaseDate = DateTime.Now,
                    SupplierID = 1
                }
                ,
                new Product
                {
                    ID = 4,
                    Description = "Descriptions 4",
                    Name = "Product 4",
                    Price = 100,
                    Rating = 1,
                    DiscontinuedDate = DateTime.Now,
                    ReleaseDate = DateTime.Now,
                    SupplierID = 1
                }
            );
        }
    }
}

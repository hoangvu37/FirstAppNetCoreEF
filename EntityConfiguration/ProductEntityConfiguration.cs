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

            builder.Property(s => s.ID).ValueGeneratedOnAdd();

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

            builder.HasMany(p => p.Categorys)
                .WithMany(s => s.Products)
                .UsingEntity(j => 
                    j.ToTable("CategoryProduct")
                    .HasData(
                        new { CategorysID = 1, ProductsID = (long)1 },                   
                        new { CategorysID = 1, ProductsID = (long)2 },
                        new { CategorysID = 1, ProductsID = (long)3 },
                        new { CategorysID = 1, ProductsID = (long)4 },
                        new { CategorysID = 2, ProductsID = (long)1 },
                        new { CategorysID = 2, ProductsID = (long)2 },
                        new { CategorysID = 2, ProductsID = (long)3 },
                        new { CategorysID = 2, ProductsID = (long)4 }
                    )
                );

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
                    Name = "Prodcut 4",
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

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.EntityConfiguration
{
    public class ProductCategoryEntityConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(s => s.ID);

            builder.HasOne(p => p.Product)
                .WithMany(s => s.ProductCategorys).HasForeignKey(p => p.ProductID);

            builder.HasOne(p => p.Category)
                .WithMany(s => s.ProductCategorys).HasForeignKey(p => p.CategoryID);

            builder.HasData(
                new ProductCategory { 
                    ID= 1, ProductID = 1, CategoryID = 1
                },
                new ProductCategory
                {
                    ID = 2,
                    ProductID = 2,
                    CategoryID = 1
                },
                new ProductCategory
                {
                    ID = 3,
                    ProductID = 3,
                    CategoryID = 2
                },
                new ProductCategory
                {
                    ID = 4,
                    ProductID = 2,
                    CategoryID = 3
                },
                new ProductCategory
                {
                    ID = 5,
                    ProductID = 4,
                    CategoryID = 4
                }
            );
        }
    }
}

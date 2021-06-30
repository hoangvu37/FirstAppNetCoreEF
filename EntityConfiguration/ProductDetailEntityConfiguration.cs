using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.EntityConfiguration
{
    public class ProductDetailtEntityConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID).ValueGeneratedOnAdd();

            builder.Property(p => p.Details)
                    .IsRequired()
                    .HasMaxLength(1024);

            builder.HasOne(p => p.Product)
               .WithOne(s => s.ProductDetail)
               .HasForeignKey<ProductDetail>(p => p.ProductID);

            builder.HasData(
                new ProductDetail { ID = 1, Details = "ProductID Details 1", ProductID = (long)1 },
                new ProductDetail { ID = 2, Details = "ProductID Details 2", ProductID = (long)2 },
                new ProductDetail { ID = 3, Details = "ProductID Details 3", ProductID = (long)3 },
                new ProductDetail { ID = 4, Details = "ProductID Details 4", ProductID = (long)4 }
            );

        }
    }
}

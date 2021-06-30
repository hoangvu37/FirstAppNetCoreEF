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

            builder.Property(p => p.Details)
                    .IsRequired()
                    .IsUnicode(true)
                    .HasMaxLength(1024);

            builder.HasData(
                new ProductDetail { ID = 1,Details = "Details 1", ProductID =1 },
                new ProductDetail { ID = 2, Details = "Details 2", ProductID = 2 },
                new ProductDetail { ID = 3, Details = "Details 3", ProductID = 3 },
                new ProductDetail { ID = 4, Details = "Details 4" , ProductID = 4 }

            );

        }
    }
}

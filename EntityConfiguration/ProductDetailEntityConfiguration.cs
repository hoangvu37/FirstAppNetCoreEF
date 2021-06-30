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

        }
    }
}

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
        }
    }
}

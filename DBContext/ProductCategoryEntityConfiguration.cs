using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.DBContext
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
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.DBContext
{
    
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(p => p.Name)
                    .IsRequired()
                    .IsUnicode(true)
                    .HasMaxLength(256);

            //builder.HasMany(s => s.Products)
            //    .WithMany(c => c.Categorys)
            //    .UsingEntity(c =>
            //    {
            //        c.ToTable("ProductCategory");
            //    });
        }
    }
}

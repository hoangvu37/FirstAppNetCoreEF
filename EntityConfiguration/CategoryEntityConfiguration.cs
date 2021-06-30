using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.EntityConfiguration
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
            builder.HasData(
                new Category
                {
                    ID = 1, Name = "Category 1"
                },
                new Category
                {
                    ID = 2,
                    Name = "Category 2"
                },
                new Category
                {
                    ID = 3,
                    Name = "Category 3"
                },
                new Category
                {
                    ID = 4,
                    Name = "Category 4"
                }
                ,
                new Category
                {
                    ID = 5,
                    Name = "Category 5"
                }
            );
            //builder.HasMany(s => s.Products)
            //    .WithMany(c => c.Categorys)
            //    .UsingEntity(c =>
            //    {
            //        c.ToTable("ProductCategory");
            //    });
        }
    }
}

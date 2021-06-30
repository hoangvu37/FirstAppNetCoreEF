using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using netcoreapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcoreapi.EntityConfiguration
{
    public class SupplierEntityConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(s => s.ID);

            builder.Property(s => s.ID).ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                    .IsRequired()
                    .IsUnicode(true)
                    .HasMaxLength(256);

            builder.HasData(
                new Supplier
                {
                    ID= 1, Address =  "Address", Name = "Name 1"
                },
                new Supplier
                {
                    ID = 2,
                    Address = "Address",
                    Name = "Name 1"
                }
            );
        }
    }
}

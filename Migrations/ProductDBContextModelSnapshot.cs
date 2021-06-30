﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using netcoreapi.DBContext;

namespace netcoreapi.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    partial class ProductDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategorysID")
                        .HasColumnType("int");

                    b.Property<long>("ProductsID")
                        .HasColumnType("bigint");

                    b.HasKey("CategorysID", "ProductsID");

                    b.HasIndex("ProductsID");

                    b.ToTable("CategoryProduct");

                    b.HasData(
                        new
                        {
                            CategorysID = 1,
                            ProductsID = 1L
                        },
                        new
                        {
                            CategorysID = 1,
                            ProductsID = 2L
                        },
                        new
                        {
                            CategorysID = 1,
                            ProductsID = 3L
                        },
                        new
                        {
                            CategorysID = 1,
                            ProductsID = 4L
                        },
                        new
                        {
                            CategorysID = 2,
                            ProductsID = 1L
                        },
                        new
                        {
                            CategorysID = 2,
                            ProductsID = 2L
                        },
                        new
                        {
                            CategorysID = 2,
                            ProductsID = 3L
                        },
                        new
                        {
                            CategorysID = 2,
                            ProductsID = 4L
                        });
                });

            modelBuilder.Entity("netcoreapi.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("ID");

                    b.ToTable("Categorys");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Category 1"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Category 2"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Category 3"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Category 4"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Category 5"
                        });
                });

            modelBuilder.Entity("netcoreapi.Models.Product", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DiscontinuedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<short>("Rating")
                        .HasColumnType("smallint");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Description = "Descriptions",
                            DiscontinuedDate = new DateTime(2021, 6, 30, 23, 39, 29, 256, DateTimeKind.Local).AddTicks(3350),
                            Name = "Product 1",
                            Price = 100.0,
                            Rating = (short)1,
                            ReleaseDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(4897),
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 2L,
                            Description = "Descriptions",
                            DiscontinuedDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6218),
                            Name = "Product 2",
                            Price = 100.0,
                            Rating = (short)1,
                            ReleaseDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6228),
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 3L,
                            Description = "Descriptions 3",
                            DiscontinuedDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6231),
                            Name = "Product 3 ",
                            Price = 100.0,
                            Rating = (short)1,
                            ReleaseDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6232),
                            SupplierID = 1
                        },
                        new
                        {
                            ID = 4L,
                            Description = "Descriptions 4",
                            DiscontinuedDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6234),
                            Name = "Prodcut 4",
                            Price = 100.0,
                            Rating = (short)1,
                            ReleaseDate = new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6235),
                            SupplierID = 1
                        });
                });

            modelBuilder.Entity("netcoreapi.Models.ProductDetail", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("ProductDetails");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            Details = "ProductID Details 1",
                            ProductID = 1L
                        },
                        new
                        {
                            ID = 2L,
                            Details = "ProductID Details 2",
                            ProductID = 2L
                        },
                        new
                        {
                            ID = 3L,
                            Details = "ProductID Details 3",
                            ProductID = 3L
                        },
                        new
                        {
                            ID = 4L,
                            Details = "ProductID Details 4",
                            ProductID = 4L
                        });
                });

            modelBuilder.Entity("netcoreapi.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Address",
                            Name = "Name 1"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Address",
                            Name = "Name 1"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("netcoreapi.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("CategorysID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("netcoreapi.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("netcoreapi.Models.Product", b =>
                {
                    b.HasOne("netcoreapi.Models.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("netcoreapi.Models.ProductDetail", b =>
                {
                    b.HasOne("netcoreapi.Models.Product", "Product")
                        .WithOne("ProductDetail")
                        .HasForeignKey("netcoreapi.Models.ProductDetail", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("netcoreapi.Models.Product", b =>
                {
                    b.Navigation("ProductDetail");
                });

            modelBuilder.Entity("netcoreapi.Models.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}

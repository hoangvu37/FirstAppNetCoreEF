using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoreapi.Migrations
{
    public partial class initdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscontinuedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<short>(type: "smallint", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategorysID = table.Column<int>(type: "int", nullable: false),
                    ProductsID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategorysID, x.ProductsID });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categorys_CategorysID",
                        column: x => x.CategorysID,
                        principalTable: "Categorys",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_ProductsID",
                        column: x => x.ProductsID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorys",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Category 1" },
                    { 2, "Category 2" },
                    { 3, "Category 3" },
                    { 4, "Category 4" },
                    { 5, "Category 5" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "ID", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Address", "Name 1" },
                    { 2, "Address", "Name 1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "DiscontinuedDate", "Name", "Price", "Rating", "ReleaseDate", "SupplierID" },
                values: new object[,]
                {
                    { 1L, "Descriptions", new DateTime(2021, 6, 30, 23, 39, 29, 256, DateTimeKind.Local).AddTicks(3350), "Product 1", 100.0, (short)1, new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(4897), 1 },
                    { 2L, "Descriptions", new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6218), "Product 2", 100.0, (short)1, new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6228), 1 },
                    { 3L, "Descriptions 3", new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6231), "Product 3 ", 100.0, (short)1, new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6232), 1 },
                    { 4L, "Descriptions 4", new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6234), "Prodcut 4", 100.0, (short)1, new DateTime(2021, 6, 30, 23, 39, 29, 257, DateTimeKind.Local).AddTicks(6235), 1 }
                });

            migrationBuilder.InsertData(
                table: "CategoryProduct",
                columns: new[] { "CategorysID", "ProductsID" },
                values: new object[,]
                {
                    { 1, 1L },
                    { 2, 1L },
                    { 1, 2L },
                    { 2, 2L },
                    { 1, 3L },
                    { 2, 3L },
                    { 1, 4L },
                    { 2, 4L }
                });

            migrationBuilder.InsertData(
                table: "ProductDetails",
                columns: new[] { "ID", "Details", "ProductID" },
                values: new object[,]
                {
                    { 1L, "ProductID Details 1", 1L },
                    { 2L, "ProductID Details 2", 2L },
                    { 3L, "ProductID Details 3", 3L },
                    { 4L, "ProductID Details 4", 4L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsID",
                table: "CategoryProduct",
                column: "ProductsID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierID",
                table: "Products",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}

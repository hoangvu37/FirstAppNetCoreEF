using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoreapi.Migrations
{
    public partial class dataseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Suppliers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                    { 1L, "Descriptions", new DateTime(2021, 6, 30, 17, 54, 12, 541, DateTimeKind.Local).AddTicks(1842), "Prodcut1", 100.0, (short)1, new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(2873), 1 },
                    { 2L, "Descriptions", new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(4294), "Prodcut 2", 100.0, (short)1, new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(4304), 1 },
                    { 3L, "Descriptions 3", new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(4307), "Prodcut 3 ", 100.0, (short)1, new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(4309), 1 },
                    { 4L, "Descriptions 4", new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(4311), "Prodcut 4", 100.0, (short)1, new DateTime(2021, 6, 30, 17, 54, 12, 542, DateTimeKind.Local).AddTicks(4312), 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "ID", "CategoryID", "ProductID" },
                values: new object[,]
                {
                    { 1L, 1, 1L },
                    { 2L, 1, 2L },
                    { 4L, 3, 2L },
                    { 3L, 2, 3L },
                    { 5L, 4, 4L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categorys",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Suppliers",
                type: "int",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<int>(
                name: "Address",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}

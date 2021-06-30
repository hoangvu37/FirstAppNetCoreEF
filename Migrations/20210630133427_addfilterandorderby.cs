using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoreapi.Migrations
{
    public partial class addfilterandorderby : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 34, 26, 741, DateTimeKind.Local).AddTicks(3225), "Product 1", new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(6420), "Product 2", new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(6436), "Product 3 ", new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(6441), "Product 4", new DateTime(2021, 6, 30, 20, 34, 26, 742, DateTimeKind.Local).AddTicks(6443) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 445, DateTimeKind.Local).AddTicks(4493), "Prodcut1", new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7489), "Prodcut 2", new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7502), "Prodcut 3 ", new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DiscontinuedDate", "Name", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7505), "Prodcut 4", new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7506) });
        }
    }
}

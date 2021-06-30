using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoreapi.Migrations
{
    public partial class detailseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 22, 42, 137, DateTimeKind.Local).AddTicks(8813), new DateTime(2021, 6, 30, 21, 22, 42, 138, DateTimeKind.Local).AddTicks(9695) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 22, 42, 139, DateTimeKind.Local).AddTicks(995), new DateTime(2021, 6, 30, 21, 22, 42, 139, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 22, 42, 139, DateTimeKind.Local).AddTicks(1008), new DateTime(2021, 6, 30, 21, 22, 42, 139, DateTimeKind.Local).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 22, 42, 139, DateTimeKind.Local).AddTicks(1011), new DateTime(2021, 6, 30, 21, 22, 42, 139, DateTimeKind.Local).AddTicks(1012) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 20, 4, 515, DateTimeKind.Local).AddTicks(4070), new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(8792), new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(8806), new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(8810), new DateTime(2021, 6, 30, 21, 20, 4, 516, DateTimeKind.Local).AddTicks(8811) });
        }
    }
}

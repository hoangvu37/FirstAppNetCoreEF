using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace netcoreapi.Migrations
{
    public partial class addseeddbdetailsproduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 1L,
                column: "ProductID",
                value: 1L);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 2L,
                column: "ProductID",
                value: 2L);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 3L,
                column: "ProductID",
                value: 3L);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 4L,
                column: "ProductID",
                value: 4L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 445, DateTimeKind.Local).AddTicks(4493), new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7489), new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7502), new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7505), new DateTime(2021, 6, 30, 20, 9, 9, 446, DateTimeKind.Local).AddTicks(7506) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 1L,
                column: "ProductID",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 8, 12, 520, DateTimeKind.Local).AddTicks(5014), new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(8102), new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(8115), new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DiscontinuedDate", "ReleaseDate" },
                values: new object[] { new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(8118), new DateTime(2021, 6, 30, 20, 8, 12, 521, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 2L,
                column: "ProductID",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 3L,
                column: "ProductID",
                value: 0L);

            migrationBuilder.UpdateData(
                table: "ProductDetails",
                keyColumn: "ID",
                keyValue: 4L,
                column: "ProductID",
                value: 0L);
        }
    }
}

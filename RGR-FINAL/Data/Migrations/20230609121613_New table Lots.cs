using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RGR_FINAL.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewtableLots : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "data",
                table: "Lots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 9, 21, 16, 13, 752, DateTimeKind.Local).AddTicks(8405), new DateTime(2023, 6, 9, 16, 16, 13, 752, DateTimeKind.Local).AddTicks(8433) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "data",
                table: "Lots",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndTime", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 9, 21, 10, 48, 642, DateTimeKind.Local).AddTicks(1196), new DateTime(2023, 6, 9, 16, 10, 48, 642, DateTimeKind.Local).AddTicks(1222) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backomm.Migrations
{
    public partial class TestSeederMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 65, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 65, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 65, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 65, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "ModifiedDate", "Title", "addedDate" },
                values: new object[] { 5, "Test Category", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test", new DateTime(2019, 10, 27, 17, 50, 6, 65, DateTimeKind.Local).AddTicks(6113) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 4, 7, 58, 531, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 4, 7, 58, 531, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 4, 7, 58, 531, DateTimeKind.Local).AddTicks(884));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 4, 7, 58, 531, DateTimeKind.Local).AddTicks(954));
        }
    }
}

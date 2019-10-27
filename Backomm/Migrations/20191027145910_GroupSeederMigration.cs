using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backomm.Migrations
{
    public partial class GroupSeederMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 59, 10, 4, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 59, 10, 4, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 59, 10, 4, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 59, 10, 4, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 59, 10, 4, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "CategoryId", "Description", "ModifiedDate", "Title", "addedDate" },
                values: new object[] { 1, null, "Group 1 Description", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Group 1 Test", new DateTime(2019, 10, 27, 17, 59, 10, 25, DateTimeKind.Local).AddTicks(1701) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 221, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 221, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 221, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 221, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 27, 17, 50, 6, 221, DateTimeKind.Local).AddTicks(8660));
        }
    }
}

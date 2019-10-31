using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backomm.Migrations
{
    public partial class CountyRelationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 83, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 83, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 83, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 83, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 83, DateTimeKind.Local).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 95, DateTimeKind.Local).AddTicks(4784));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 175, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 175, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 175, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 175, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 175, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 175, DateTimeKind.Local).AddTicks(9634));
        }
    }
}

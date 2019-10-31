using System;
using System.Net;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backomm.Migrations
{
    public partial class BaseModelAddedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "addedDate",
                table: "Images",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "FacebookUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "addedDate",
                table: "FacebookUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Counties",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "addedDate",
                table: "Counties",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "addedDate",
                table: "Cities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 41, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 41, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 41, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 41, DateTimeKind.Local).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 41, DateTimeKind.Local).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 23, 38, 70, DateTimeKind.Local).AddTicks(4734));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "addedDate",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "FacebookUsers");

            migrationBuilder.DropColumn(
                name: "addedDate",
                table: "FacebookUsers");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "addedDate",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "addedDate",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 20, 51, 55, 371, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 20, 51, 55, 371, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 20, 51, 55, 371, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 20, 51, 55, 371, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 20, 51, 55, 371, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 20, 51, 55, 371, DateTimeKind.Local).AddTicks(6466));
        }
    }
}

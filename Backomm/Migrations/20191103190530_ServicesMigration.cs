using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backomm.Migrations
{
    public partial class ServicesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WebServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    addedDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WebServices_Users_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 11, 3, 22, 5, 30, 141, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 11, 3, 22, 5, 30, 141, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 11, 3, 22, 5, 30, 141, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 11, 3, 22, 5, 30, 141, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 11, 3, 22, 5, 30, 141, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 11, 3, 22, 5, 30, 162, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.CreateIndex(
                name: "IX_WebServices_ApplicationUserId",
                table: "WebServices",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebServices");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 165, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 165, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 165, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 165, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 165, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "addedDate",
                value: new DateTime(2019, 10, 31, 21, 35, 38, 165, DateTimeKind.Local).AddTicks(6154));
        }
    }
}

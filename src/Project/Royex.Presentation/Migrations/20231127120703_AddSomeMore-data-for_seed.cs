using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Royex.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class AddSomeMoredatafor_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "IsBonusAdded", "JoiningDate", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { 7, true, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tom", 1, 200 },
                    { 8, false, new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asik", 2, 100 },
                    { 9, false, new DateTime(2011, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asad", 1, 100 },
                    { 10, false, new DateTime(2019, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Haskil", 2, 100 },
                    { 11, false, new DateTime(2000, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Comok", 1, 200 },
                    { 12, false, new DateTime(2015, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mijan", 2, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Royex.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class Intialize_DataBase_and_Seed_Data_12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OfficeExecutives",
                columns: new[] { "Id", "GeneralManagerId", "JoiningDate", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sohel", 2, 100 },
                    { 2, 3, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kawser", 2, 200 },
                    { 3, 1, new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azad", 2, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OfficeExecutives",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OfficeExecutives",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OfficeExecutives",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

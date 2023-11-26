using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Royex.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class Intialize_DataBase_and_Seed_Data_11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GeneralManager",
                columns: new[] { "Id", "JoiningDate", "ManagerId", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Abir", 1, 200 },
                    { 2, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Saddam", 1, 200 },
                    { 3, new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Osman", 1, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GeneralManager",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GeneralManager",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GeneralManager",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

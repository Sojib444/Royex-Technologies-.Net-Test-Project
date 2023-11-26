using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Royex.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class Inital_data_seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "JoiningDate", "Name", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Abir", 0, 200 },
                    { 2, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saddam", 1, 200 },
                    { 3, new DateTime(2010, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osman", 1, 200 },
                    { 4, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sohel", 2, 100 },
                    { 5, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kawser", 2, 200 },
                    { 6, new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Azad", 2, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}

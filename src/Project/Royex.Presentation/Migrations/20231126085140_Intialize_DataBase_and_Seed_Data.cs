using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Royex.Presentation.Migrations
{
    /// <inheritdoc />
    public partial class Intialize_DataBase_and_Seed_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manager",
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
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralManager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralManager", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GeneralManager_Manager_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Manager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfficeExecutives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GeneralManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficeExecutives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfficeExecutives_GeneralManager_GeneralManagerId",
                        column: x => x.GeneralManagerId,
                        principalTable: "GeneralManager",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Manager",
                columns: new[] { "Id", "JoiningDate", "Name", "Position", "Salary" },
                values: new object[] { 1, new DateTime(1999, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sojib", 0, 500 });

            migrationBuilder.CreateIndex(
                name: "IX_GeneralManager_ManagerId",
                table: "GeneralManager",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_OfficeExecutives_GeneralManagerId",
                table: "OfficeExecutives",
                column: "GeneralManagerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficeExecutives");

            migrationBuilder.DropTable(
                name: "GeneralManager");

            migrationBuilder.DropTable(
                name: "Manager");
        }
    }
}

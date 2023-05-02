using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiMIddleware.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorLogger",
                columns: table => new
                {
                    LoggerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ErrorDetails = table.Column<string>(type: "TEXT", nullable: false),
                    LogDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogger", x => x.LoggerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorLogger");
        }
    }
}

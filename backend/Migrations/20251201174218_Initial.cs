using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_BD.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sprzet_",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Typ = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    Rozmiar = table.Column<int>(type: "int", nullable: false),
                    Data_zakupu = table.Column<DateTime>(type: "date", nullable: false),
                    Koszt_wypozyczenia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sprzet_", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sprzet_");
        }
    }
}

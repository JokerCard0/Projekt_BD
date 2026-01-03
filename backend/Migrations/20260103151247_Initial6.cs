using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_BD.Migrations
{
    /// <inheritdoc />
    public partial class Initial6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Wypozyczony",
                table: "Sprzety",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wypozyczony",
                table: "Sprzety");
        }
    }
}

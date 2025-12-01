using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_BD.Migrations
{
    /// <inheritdoc />
    public partial class Initial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sprzet_",
                table: "Sprzet_");

            migrationBuilder.RenameTable(
                name: "Sprzet_",
                newName: "Sprzety");

            migrationBuilder.AlterColumn<int>(
                name: "Rozmiar",
                table: "Sprzety",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "intiger");

            migrationBuilder.AlterColumn<int>(
                name: "Koszt_wypozyczenia",
                table: "Sprzety",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "intiger");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sprzety",
                table: "Sprzety",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Sprzety",
                table: "Sprzety");

            migrationBuilder.RenameTable(
                name: "Sprzety",
                newName: "Sprzet_");

            migrationBuilder.AlterColumn<int>(
                name: "Rozmiar",
                table: "Sprzet_",
                type: "intiger",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Koszt_wypozyczenia",
                table: "Sprzet_",
                type: "intiger",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sprzet_",
                table: "Sprzet_",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt_BD.Migrations
{
    /// <inheritdoc />
    public partial class Initial8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Opinie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OcenaSperzetu = table.Column<int>(type: "int", nullable: false),
                    OcenaObslugi = table.Column<int>(type: "int", nullable: false),
                    OcenaZwrotu = table.Column<int>(type: "int", nullable: false),
                    Tresc = table.Column<string>(type: "nvarchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Opinie", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Opinie");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Keszprojekt.Data.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alkatreszek",
                columns: table => new
                {
                    AlkatreszekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SulyGr = table.Column<int>(type: "int", nullable: false),
                    Ar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alkatreszek", x => x.AlkatreszekId);
                });

            migrationBuilder.CreateTable(
                name: "Termekek",
                columns: table => new
                {
                    TermekekId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Megnevezes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SulyGr = table.Column<int>(type: "int", nullable: false),
                    Ar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termekek", x => x.TermekekId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alkatreszek");

            migrationBuilder.DropTable(
                name: "Termekek");
        }
    }
}

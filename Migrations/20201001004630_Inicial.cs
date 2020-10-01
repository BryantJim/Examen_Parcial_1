using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Examen_Parcial_1.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NCFAutorizados",
                columns: table => new
                {
                    NcfId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoNcfId = table.Column<int>(nullable: false),
                    Secuencia = table.Column<int>(nullable: false),
                    Limite = table.Column<int>(nullable: false),
                    Reorden = table.Column<int>(nullable: false),
                    Vence = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NCFAutorizados", x => x.NcfId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NCFAutorizados");
        }
    }
}

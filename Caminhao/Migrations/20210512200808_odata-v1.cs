using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Caminhao.Migrations
{
    public partial class odatav1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caminhao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modelo = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    AnoFabricacao = table.Column<short>(type: "smallint", maxLength: 4, nullable: false),
                    AnoModelo = table.Column<short>(type: "smallint", maxLength: 4, nullable: false),
                    Erro = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminhao", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caminhao");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestStore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nom = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Prenom = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true),
                    Cp = table.Column<int>(type: "INTEGER", nullable: false),
                    Localite = table.Column<string>(type: "TEXT", nullable: true),
                    Rue = table.Column<string>(type: "TEXT", nullable: true),
                    Numero = table.Column<string>(type: "TEXT", nullable: true),
                    Tel = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}

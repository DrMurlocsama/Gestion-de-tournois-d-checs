using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TournoiEchec.DAL.Migrations
{
    public partial class Tournoi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Joueurs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pseudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaiss = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Elo = table.Column<int>(type: "int", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueurs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournois",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NbJoueurMin = table.Column<int>(type: "int", nullable: true),
                    NbJoueurMax = table.Column<int>(type: "int", nullable: true),
                    EloMax = table.Column<int>(type: "int", nullable: true),
                    Elomin = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Categorie = table.Column<int>(type: "int", nullable: false),
                    Création = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinInscription = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MiseAJour = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WomenOnly = table.Column<bool>(type: "bit", nullable: false),
                    RondeCourant = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournois", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joueurs");

            migrationBuilder.DropTable(
                name: "Tournois");
        }
    }
}

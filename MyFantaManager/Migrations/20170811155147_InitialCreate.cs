using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFantaManager.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayersContainers",
                columns: table => new
                {
                    PlayersDataId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayersContainers", x => x.PlayersDataId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cognome = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Nominativo = table.Column<string>(nullable: true),
                    PlayerContainerPlayersDataId = table.Column<int>(nullable: true),
                    Ruolo = table.Column<string>(nullable: true),
                    Squadra = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Players_PlayersContainers_PlayerContainerPlayersDataId",
                        column: x => x.PlayerContainerPlayersDataId,
                        principalTable: "PlayersContainers",
                        principalColumn: "PlayersDataId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_PlayerContainerPlayersDataId",
                table: "Players",
                column: "PlayerContainerPlayersDataId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "PlayersContainers");
        }
    }
}

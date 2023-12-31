﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MinimalApi.Migrations
{
    /// <inheritdoc />
    public partial class prova : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "utente",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: false),
                    cognome = table.Column<string>(type: "TEXT", nullable: false),
                    indirizzo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_utente", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "nmail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    utenteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nmail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nmail_utente_utenteId",
                        column: x => x.utenteId,
                        principalTable: "utente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ntelefono",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    numero = table.Column<int>(type: "INTEGER", nullable: false),
                    utenteId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ntelefono", x => x.id);
                    table.ForeignKey(
                        name: "FK_ntelefono_utente_utenteId",
                        column: x => x.utenteId,
                        principalTable: "utente",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_nmail_utenteId",
                table: "nmail",
                column: "utenteId");

            migrationBuilder.CreateIndex(
                name: "IX_ntelefono_utenteId",
                table: "ntelefono",
                column: "utenteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "nmail");

            migrationBuilder.DropTable(
                name: "ntelefono");

            migrationBuilder.DropTable(
                name: "utente");
        }
    }
}

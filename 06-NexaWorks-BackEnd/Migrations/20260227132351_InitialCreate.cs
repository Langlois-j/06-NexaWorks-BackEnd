using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _06_NexaWorks_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomOS = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomProduit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomStatut = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VersionProduit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProduit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionProduit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionProduit_Produit_IdProduit",
                        column: x => x.IdProduit,
                        principalTable: "Produit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduit = table.Column<int>(type: "int", nullable: false),
                    IdVersionProduit = table.Column<int>(type: "int", nullable: false),
                    IdOS = table.Column<int>(type: "int", nullable: false),
                    IdStatut = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ResolutionDate = table.Column<DateOnly>(type: "date", nullable: true),
                    DescriptionTexte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResolutionTexte = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_OS_IdOS",
                        column: x => x.IdOS,
                        principalTable: "OS",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Produit_IdProduit",
                        column: x => x.IdProduit,
                        principalTable: "Produit",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Statuts_IdStatut",
                        column: x => x.IdStatut,
                        principalTable: "Statuts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_VersionProduit_IdVersionProduit",
                        column: x => x.IdVersionProduit,
                        principalTable: "VersionProduit",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "VersionProduitOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdVersionProduit = table.Column<int>(type: "int", nullable: false),
                    IdOS = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionProduitOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VersionProduitOS_OS_IdOS",
                        column: x => x.IdOS,
                        principalTable: "OS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VersionProduitOS_VersionProduit_IdVersionProduit",
                        column: x => x.IdVersionProduit,
                        principalTable: "VersionProduit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IdOS",
                table: "Tickets",
                column: "IdOS");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IdProduit",
                table: "Tickets",
                column: "IdProduit");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IdStatut",
                table: "Tickets",
                column: "IdStatut");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_IdVersionProduit",
                table: "Tickets",
                column: "IdVersionProduit");

            migrationBuilder.CreateIndex(
                name: "IX_VersionProduit_IdProduit",
                table: "VersionProduit",
                column: "IdProduit");

            migrationBuilder.CreateIndex(
                name: "IX_VersionProduitOS_IdOS",
                table: "VersionProduitOS",
                column: "IdOS");

            migrationBuilder.CreateIndex(
                name: "IX_VersionProduitOS_IdVersionProduit",
                table: "VersionProduitOS",
                column: "IdVersionProduit");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "VersionProduitOS");

            migrationBuilder.DropTable(
                name: "Statuts");

            migrationBuilder.DropTable(
                name: "OS");

            migrationBuilder.DropTable(
                name: "VersionProduit");

            migrationBuilder.DropTable(
                name: "Produit");
        }
    }
}

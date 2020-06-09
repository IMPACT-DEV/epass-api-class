using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace epass.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    Stamp = table.Column<string>(nullable: true),
                    Locked = table.Column<bool>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Otp = table.Column<string>(nullable: true),
                    Indicatif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compte",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Telephone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Hash = table.Column<string>(nullable: true),
                    Stamp = table.Column<string>(nullable: true),
                    Locked = table.Column<bool>(nullable: false),
                    Enable = table.Column<bool>(nullable: false),
                    Otp = table.Column<string>(nullable: true),
                    Indicatif = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compte", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Devise",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true),
                    CodeIso = table.Column<string>(nullable: true),
                    Symbole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paiement",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true),
                    Pays = table.Column<string>(nullable: true),
                    Pature = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paiement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pays",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Indicatif = table.Column<int>(nullable: false),
                    CodePays = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PieceIdentite",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PieceIdentite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOperation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOperation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EventLog",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    EventLogDate = table.Column<DateTime>(nullable: false),
                    Event = table.Column<string>(nullable: true),
                    AdminId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EventLog_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Operation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Libelle = table.Column<string>(nullable: true),
                    TypeOperationId = table.Column<int>(nullable: false),
                    OperationDate = table.Column<DateTime>(nullable: false),
                    OperationValeurDate = table.Column<DateTime>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    Montant = table.Column<decimal>(nullable: false),
                    AdminId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Operation_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPreference",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AdminId = table.Column<Guid>(nullable: false),
                    Langue = table.Column<string>(nullable: true),
                    DeviseId = table.Column<Guid>(nullable: false),
                    Pin = table.Column<int>(nullable: false),
                    TouchId = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPreference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPreference_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPreference_Devise_DeviseId",
                        column: x => x.DeviseId,
                        principalTable: "Devise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ville",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    PaysId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ville", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ville_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AdminId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false),
                    Valeur = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdminRole_Admin_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admin",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdminRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoCompte",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom = table.Column<string>(nullable: true),
                    Prenom = table.Column<string>(nullable: true),
                    Alias = table.Column<string>(nullable: true),
                    PhotoProfil = table.Column<byte[]>(nullable: true),
                    Naissance = table.Column<DateTime>(nullable: false),
                    PieceIdentite = table.Column<string>(nullable: true),
                    Sexe = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(nullable: true),
                    VilleId = table.Column<Guid>(nullable: false),
                    PaysId = table.Column<Guid>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Nationalite = table.Column<string>(nullable: true),
                    CompteId = table.Column<Guid>(nullable: false),
                    Activite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoCompte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoCompte_Compte_CompteId",
                        column: x => x.CompteId,
                        principalTable: "Compte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoCompte_Pays_PaysId",
                        column: x => x.PaysId,
                        principalTable: "Pays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoCompte_Ville_VilleId",
                        column: x => x.VilleId,
                        principalTable: "Ville",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminRole_AdminId",
                table: "AdminRole",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminRole_RoleId",
                table: "AdminRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EventLog_AdminId",
                table: "EventLog",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoCompte_CompteId",
                table: "InfoCompte",
                column: "CompteId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoCompte_PaysId",
                table: "InfoCompte",
                column: "PaysId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoCompte_VilleId",
                table: "InfoCompte",
                column: "VilleId");

            migrationBuilder.CreateIndex(
                name: "IX_Operation_AdminId",
                table: "Operation",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreference_AdminId",
                table: "UserPreference",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPreference_DeviseId",
                table: "UserPreference",
                column: "DeviseId");

            migrationBuilder.CreateIndex(
                name: "IX_Ville_PaysId",
                table: "Ville",
                column: "PaysId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminRole");

            migrationBuilder.DropTable(
                name: "EventLog");

            migrationBuilder.DropTable(
                name: "InfoCompte");

            migrationBuilder.DropTable(
                name: "Operation");

            migrationBuilder.DropTable(
                name: "Paiement");

            migrationBuilder.DropTable(
                name: "PieceIdentite");

            migrationBuilder.DropTable(
                name: "TypeOperation");

            migrationBuilder.DropTable(
                name: "UserPreference");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Compte");

            migrationBuilder.DropTable(
                name: "Ville");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Devise");

            migrationBuilder.DropTable(
                name: "Pays");
        }
    }
}

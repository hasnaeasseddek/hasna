using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Freelance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RelationWithApplicationUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CandidatId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrepriseId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Competences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DomaineExpertises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DomaineExpertises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrpition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatePub = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Condidats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tele = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobilite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Disponibilite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condidats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Condidats_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entreprises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RaisonSociale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entreprises_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComptenceDmExpertises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompetence = table.Column<int>(type: "int", nullable: true),
                    IdDmexpertise = table.Column<int>(type: "int", nullable: true),
                    IdCompetenceNavigationId = table.Column<int>(type: "int", nullable: true),
                    IdDmexpertiseNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComptenceDmExpertises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComptenceDmExpertises_Competences_IdCompetenceNavigationId",
                        column: x => x.IdCompetenceNavigationId,
                        principalTable: "Competences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ComptenceDmExpertises_DomaineExpertises_IdDmexpertiseNavigationId",
                        column: x => x.IdDmexpertiseNavigationId,
                        principalTable: "DomaineExpertises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CompetenceOffres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCompetence = table.Column<int>(type: "int", nullable: true),
                    IdOffre = table.Column<int>(type: "int", nullable: true),
                    IdCompetenceNavigationId = table.Column<int>(type: "int", nullable: true),
                    IdOffreNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetenceOffres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompetenceOffres_Competences_IdCompetenceNavigationId",
                        column: x => x.IdCompetenceNavigationId,
                        principalTable: "Competences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompetenceOffres_Offres_IdOffreNavigationId",
                        column: x => x.IdOffreNavigationId,
                        principalTable: "Offres",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CondidatComps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Niveau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdComp = table.Column<int>(type: "int", nullable: true),
                    IdCond = table.Column<int>(type: "int", nullable: true),
                    IdCondNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondidatComps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CondidatComps_Competences_IdComp",
                        column: x => x.IdComp,
                        principalTable: "Competences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CondidatComps_Condidats_IdCondNavigationId",
                        column: x => x.IdCondNavigationId,
                        principalTable: "Condidats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdCondidat = table.Column<int>(type: "int", nullable: true),
                    IdCondidatNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiences_Condidats_IdCondidatNavigationId",
                        column: x => x.IdCondidatNavigationId,
                        principalTable: "Condidats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Formations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Niveau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ecole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diplome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdCondidat = table.Column<int>(type: "int", nullable: true),
                    IdCondidatNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formations_Condidats_IdCondidatNavigationId",
                        column: x => x.IdCondidatNavigationId,
                        principalTable: "Condidats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdCondidat = table.Column<int>(type: "int", nullable: true),
                    IdCondidatNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projets_Condidats_IdCondidatNavigationId",
                        column: x => x.IdCondidatNavigationId,
                        principalTable: "Condidats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ConsultaionProfils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCondidat = table.Column<int>(type: "int", nullable: true),
                    IdEntreprise = table.Column<int>(type: "int", nullable: true),
                    DateConsultation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdCondidatNavigationId = table.Column<int>(type: "int", nullable: true),
                    IdEntrepriseNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultaionProfils", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsultaionProfils_Condidats_IdCondidatNavigationId",
                        column: x => x.IdCondidatNavigationId,
                        principalTable: "Condidats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ConsultaionProfils_Entreprises_IdEntrepriseNavigationId",
                        column: x => x.IdEntrepriseNavigationId,
                        principalTable: "Entreprises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Messageries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpediteurId = table.Column<int>(type: "int", nullable: true),
                    DestinataireId = table.Column<int>(type: "int", nullable: true),
                    Msg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateMsg = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpediteurNavigationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messageries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messageries_Condidats_ExpediteurId",
                        column: x => x.ExpediteurId,
                        principalTable: "Condidats",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Messageries_Entreprises_ExpediteurNavigationId",
                        column: x => x.ExpediteurNavigationId,
                        principalTable: "Entreprises",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "436c43ab-379c-4ee0-b2e0-a2d454240e53", "1", "Admin", "ADMIN" },
                    { "5fc42682-35e7-4935-bfb5-0b0cb8cd3c15", "3", "Entreprise", "ENTREPRISE" },
                    { "a8b8d9e5-1a80-470a-a2cc-20bcc3f96486", "2", "Candidat", "CANDIDAT" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceOffres_IdCompetenceNavigationId",
                table: "CompetenceOffres",
                column: "IdCompetenceNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_CompetenceOffres_IdOffreNavigationId",
                table: "CompetenceOffres",
                column: "IdOffreNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ComptenceDmExpertises_IdCompetenceNavigationId",
                table: "ComptenceDmExpertises",
                column: "IdCompetenceNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ComptenceDmExpertises_IdDmexpertiseNavigationId",
                table: "ComptenceDmExpertises",
                column: "IdDmexpertiseNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_CondidatComps_IdComp",
                table: "CondidatComps",
                column: "IdComp");

            migrationBuilder.CreateIndex(
                name: "IX_CondidatComps_IdCondNavigationId",
                table: "CondidatComps",
                column: "IdCondNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Condidats_ApplicationUserId",
                table: "Condidats",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaionProfils_IdCondidatNavigationId",
                table: "ConsultaionProfils",
                column: "IdCondidatNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultaionProfils_IdEntrepriseNavigationId",
                table: "ConsultaionProfils",
                column: "IdEntrepriseNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Entreprises_ApplicationUserId",
                table: "Entreprises",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Experiences_IdCondidatNavigationId",
                table: "Experiences",
                column: "IdCondidatNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Formations_IdCondidatNavigationId",
                table: "Formations",
                column: "IdCondidatNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Messageries_ExpediteurId",
                table: "Messageries",
                column: "ExpediteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Messageries_ExpediteurNavigationId",
                table: "Messageries",
                column: "ExpediteurNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_Projets_IdCondidatNavigationId",
                table: "Projets",
                column: "IdCondidatNavigationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompetenceOffres");

            migrationBuilder.DropTable(
                name: "ComptenceDmExpertises");

            migrationBuilder.DropTable(
                name: "CondidatComps");

            migrationBuilder.DropTable(
                name: "ConsultaionProfils");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Formations");

            migrationBuilder.DropTable(
                name: "Messageries");

            migrationBuilder.DropTable(
                name: "Projets");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Offres");

            migrationBuilder.DropTable(
                name: "DomaineExpertises");

            migrationBuilder.DropTable(
                name: "Competences");

            migrationBuilder.DropTable(
                name: "Entreprises");

            migrationBuilder.DropTable(
                name: "Condidats");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Freelance.Infrastructur.Migrations
{
    /// <inheritdoc />
    public partial class addIdUserRef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUserReference",
                table: "Entreprises",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdUserReference",
                table: "Candidat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUserReference",
                table: "Entreprises");

            migrationBuilder.DropColumn(
                name: "IdUserReference",
                table: "Candidat");
        }
    }
}

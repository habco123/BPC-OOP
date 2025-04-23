using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cv11.Migrations
{
    /// <inheritdoc />
    public partial class NoveTabulkyPokus2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPredmets",
                table: "StudentPredmets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Predmets",
                table: "Predmets");

            migrationBuilder.RenameTable(
                name: "StudentPredmets",
                newName: "StudentPredmet");

            migrationBuilder.RenameTable(
                name: "Predmets",
                newName: "Predmety");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Predmety",
                table: "Predmety",
                column: "Zkratka");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Predmety",
                table: "Predmety");

            migrationBuilder.RenameTable(
                name: "StudentPredmet",
                newName: "StudentPredmets");

            migrationBuilder.RenameTable(
                name: "Predmety",
                newName: "Predmets");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPredmets",
                table: "StudentPredmets",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Predmets",
                table: "Predmets",
                column: "Zkratka");
        }
    }
}

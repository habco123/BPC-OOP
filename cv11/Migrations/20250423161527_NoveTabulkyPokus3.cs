using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cv11.Migrations
{
    /// <inheritdoc />
    public partial class NoveTabulkyPokus3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hodnotenie",
                table: "Hodnotenie");

            migrationBuilder.DropColumn(
                name: "Znamka",
                table: "Predmety");

            migrationBuilder.RenameColumn(
                name: "DatumNarozeni",
                table: "Hodnotenie",
                newName: "Datum");

            migrationBuilder.AlterColumn<string>(
                name: "Zkratka",
                table: "StudentPredmet",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Nazev",
                table: "Predmety",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ZkratkaPredmet",
                table: "Hodnotenie",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet",
                columns: new[] { "StudentId", "Zkratka" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hodnotenie",
                table: "Hodnotenie",
                columns: new[] { "StudentId", "ZkratkaPredmet" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentPredmet_Zkratka",
                table: "StudentPredmet",
                column: "Zkratka");

            migrationBuilder.CreateIndex(
                name: "IX_Hodnotenie_ZkratkaPredmet",
                table: "Hodnotenie",
                column: "ZkratkaPredmet");

            migrationBuilder.AddForeignKey(
                name: "FK_Hodnotenie_Predmety_ZkratkaPredmet",
                table: "Hodnotenie",
                column: "ZkratkaPredmet",
                principalTable: "Predmety",
                principalColumn: "Zkratka",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hodnotenie_Students_StudentId",
                table: "Hodnotenie",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPredmet_Predmety_Zkratka",
                table: "StudentPredmet",
                column: "Zkratka",
                principalTable: "Predmety",
                principalColumn: "Zkratka",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPredmet_Students_StudentId",
                table: "StudentPredmet",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hodnotenie_Predmety_ZkratkaPredmet",
                table: "Hodnotenie");

            migrationBuilder.DropForeignKey(
                name: "FK_Hodnotenie_Students_StudentId",
                table: "Hodnotenie");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPredmet_Predmety_Zkratka",
                table: "StudentPredmet");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPredmet_Students_StudentId",
                table: "StudentPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet");

            migrationBuilder.DropIndex(
                name: "IX_StudentPredmet_Zkratka",
                table: "StudentPredmet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Hodnotenie",
                table: "Hodnotenie");

            migrationBuilder.DropIndex(
                name: "IX_Hodnotenie_ZkratkaPredmet",
                table: "Hodnotenie");

            migrationBuilder.DropColumn(
                name: "Nazev",
                table: "Predmety");

            migrationBuilder.RenameColumn(
                name: "Datum",
                table: "Hodnotenie",
                newName: "DatumNarozeni");

            migrationBuilder.AlterColumn<string>(
                name: "Zkratka",
                table: "StudentPredmet",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<double>(
                name: "Znamka",
                table: "Predmety",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "ZkratkaPredmet",
                table: "Hodnotenie",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentPredmet",
                table: "StudentPredmet",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Hodnotenie",
                table: "Hodnotenie",
                column: "StudentId");
        }
    }
}

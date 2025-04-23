using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cv11.Migrations
{
    /// <inheritdoc />
    public partial class NoveTabulky : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hodnotenie",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ZkratkaPredmet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumNarozeni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Znamka = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hodnotenie", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "Predmets",
                columns: table => new
                {
                    Zkratka = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Znamka = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Predmets", x => x.Zkratka);
                });

            migrationBuilder.CreateTable(
                name: "StudentPredmets",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Zkratka = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPredmets", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hodnotenie");

            migrationBuilder.DropTable(
                name: "Predmets");

            migrationBuilder.DropTable(
                name: "StudentPredmets");
        }
    }
}

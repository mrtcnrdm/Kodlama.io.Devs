using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddProgramingLanguageTecnology : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgramingLanguageTecnology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProgramingLanguageId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramingLanguageTecnology", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramingLanguageTecnology_ProgramingLanguage_ProgramingLanguageId",
                        column: x => x.ProgramingLanguageId,
                        principalTable: "ProgramingLanguage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProgramingLanguageTecnology_ProgramingLanguageId",
                table: "ProgramingLanguageTecnology",
                column: "ProgramingLanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProgramingLanguageTecnology");
        }
    }
}

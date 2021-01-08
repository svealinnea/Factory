using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineertName",
                table: "Engineers",
                newName: "EngineerName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EngineerName",
                table: "Engineers",
                newName: "EngineertName");
        }
    }
}

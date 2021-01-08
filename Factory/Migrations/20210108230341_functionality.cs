using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class functionality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MachineFunctionality",
                table: "Machines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineFunctionality",
                table: "Machines");
        }
    }
}

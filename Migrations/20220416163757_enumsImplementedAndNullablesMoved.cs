using Microsoft.EntityFrameworkCore.Migrations;

namespace Akvelon_Internship_Test_Task.Migrations
{
    public partial class enumsImplementedAndNullablesMoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Task",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Project");
        }
    }
}

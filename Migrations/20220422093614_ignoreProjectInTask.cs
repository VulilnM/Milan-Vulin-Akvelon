using Microsoft.EntityFrameworkCore.Migrations;

namespace Akvelon_Internship_Test_Task.Migrations
{
    public partial class ignoreProjectInTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectId",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProjectId",
                table: "Task");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Task");

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProjectFK",
                table: "Task",
                column: "ProjectFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectFK",
                table: "Task",
                column: "ProjectFK",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Project_ProjectFK",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_ProjectFK",
                table: "Task");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Task",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Task_ProjectId",
                table: "Task",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Project_ProjectId",
                table: "Task",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

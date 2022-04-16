using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Akvelon_Internship_Test_Task.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "CompletionDate", "ProjectName", "ProjectPriority", "StartDate", "Status" },
                values: new object[] { 1, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ClickUp", 1, new DateTime(2021, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "CompletionDate", "ProjectName", "ProjectPriority", "StartDate", "Status" },
                values: new object[] { 2, new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clockify", 2, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "ProjectId", "CompletionDate", "ProjectName", "ProjectPriority", "StartDate", "Status" },
                values: new object[] { 3, new DateTime(2024, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Airbnb", 3, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Task",
                columns: new[] { "TaskId", "ProjectFK", "Status", "TaskDescription", "TaskName", "TaskPriority" },
                values: new object[,]
                {
                    { 1, 1, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "User Data Pagination", 1 },
                    { 2, 1, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Login/Register functionality", 2 },
                    { 3, 1, 2, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Home Page View For Mobile", 1 },
                    { 4, 2, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Convert timezones for middle-east users", 1 },
                    { 5, 2, 3, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Fix drop-down side menu bug", 3 },
                    { 6, 3, 1, "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.", "Set up online payments with $BTC (Bitcoin)", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Task",
                keyColumn: "TaskId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "ProjectId",
                keyValue: 3);
        }
    }
}

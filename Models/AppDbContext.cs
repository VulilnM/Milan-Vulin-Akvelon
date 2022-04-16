using Microsoft.EntityFrameworkCore;
using System;

namespace Akvelon_Internship_Test_Task.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Seeding the inital data to the database
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project()
                {
                    // ProjectID should be auto-increment but it has to be explicitly specified or else it throws an exception?
                    ProjectId = 1,
                    ProjectName = "ClickUp",
                    StartDate = new DateTime(2021, 7, 24),
                    CompletionDate = new DateTime(2022, 9, 11),
                    Status = Models.Project.ProjectStatus.Active,
                    ProjectPriority = 1,
                },
                new Project()
                {
                    ProjectId = 2,
                    ProjectName = "Clockify",
                    StartDate = new DateTime(2020, 3, 1),
                    CompletionDate = new DateTime(2021, 6, 8),
                    Status = Models.Project.ProjectStatus.Completed,
                    ProjectPriority = 2
                },
                new Project()
                {
                    ProjectId = 3,
                    ProjectName = "Airbnb",
                    StartDate = new DateTime(2022, 10, 1),
                    CompletionDate = new DateTime(2024, 10, 1),
                    Status = Models.Project.ProjectStatus.NotStarted,
                    ProjectPriority = 3
                }
            );

            modelBuilder.Entity<Task>().HasData(
                new Task()
                {
                    TaskId = 1,
                    TaskName = "User Data Pagination",
                    TaskDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Status = Models.Task.TaskStatus.InProgress,
                    TaskPriority = 1,
                    ProjectFK = 1
                },
                new Task()
                {
                    TaskId = 2,
                    TaskName = "Login/Register functionality",
                    TaskDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Status = Models.Task.TaskStatus.ToDo,
                    TaskPriority = 2,
                    ProjectFK = 1
                },
                new Task()
                {
                    TaskId = 3,
                    TaskName = "Home Page View For Mobile",
                    TaskDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Status = Models.Task.TaskStatus.InProgress,
                    TaskPriority = 1,
                    ProjectFK = 1
                },
                new Task()
                {
                    TaskId = 4,
                    TaskName = "Convert timezones for middle-east users",
                    TaskDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Status = Models.Task.TaskStatus.Done,
                    TaskPriority = 1,
                    ProjectFK = 2
                },
                new Task()
                {
                    TaskId = 5,
                    TaskName = "Fix drop-down side menu bug",
                    TaskDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Status = Models.Task.TaskStatus.Done,
                    TaskPriority = 3,
                    ProjectFK = 2
                },
                new Task()
                {
                    TaskId = 6,
                    TaskName = "Set up online payments with $BTC (Bitcoin)",
                    TaskDescription = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book.",
                    Status = Models.Task.TaskStatus.ToDo,
                    TaskPriority = 1,
                    ProjectFK = 3
                }
            );
        }

            DbSet<Task> Task { get; set; }
        DbSet<Project> Project { get; set; }

    }
}

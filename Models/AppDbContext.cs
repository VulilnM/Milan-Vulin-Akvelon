using Microsoft.EntityFrameworkCore;

namespace Akvelon_Internship_Test_Task.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        DbSet<Task> Task { get; set; }
        DbSet<Project> Project { get; set; }

    }
}

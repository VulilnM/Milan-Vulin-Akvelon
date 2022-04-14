using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Akvelon_Internship_Test_Task.Models
{
    public class Task
    {

        [Key]
        public int TaskId { get; set; }

        [Required]
        public string TaskName { get; set; }

        public enum TaskStatus
        {
            ToDo,
            InProgress,
            Done
        }

        // Maximum and minimum task description length 
        [StringLength(1000, MinimumLength = 100)]
        [Column(TypeName = "varchar(1000)")]
        public string? TaskDescription { get; set; }

        [Required]
        public int TaskPriority { get; set; }
    }
}

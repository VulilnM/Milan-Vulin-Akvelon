
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Akvelon_Internship_Test_Task.Models
{

    public class Task
    {

        [Key]
        [SwaggerSchema(ReadOnly = true)]
        public int TaskId { get; set; }

        [Required]
        public string TaskName { get; set; }

        // Enumerator for task status
        // ToDo = 1
        // InProgress = 2
        // Done = 3
        public enum TaskStatus
        {
            ToDo = 1,
            InProgress,
            Done
        }

        public TaskStatus Status { get; set; }

        [Required]
        // The priority can only be from 1(very low) to 5(very high)
        [Range(1, 5)]
        public int TaskPriority { get; set; }

        [ForeignKey("Project")]
        public int ProjectFK { get; set; }

        //Nullable fields
        #nullable enable
        // Maximum and minimum task description length 
        [StringLength(1000, MinimumLength = 100)]
        [Column(TypeName = "varchar(1000)")]
        public string? TaskDescription { get; set; }

        [SwaggerSchema(ReadOnly = true)]
        [JsonIgnore]
        public Project? Project { get; set; }
        #nullable disable
        
    }
}

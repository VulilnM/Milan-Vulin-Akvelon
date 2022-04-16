using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Akvelon_Internship_Test_Task.Models
{
    public class Project
    {

        [Key]
        public int ProjectId { get; set; }

        [Required]
        public string ProjectName { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        // Enumerator for project status
        // NotStarted = 1
        // Active = 2
        // Completed = 3
        public enum ProjectStatus
        {
            NotStarted = 1,
            Active,
            Completed
        }

        public ProjectStatus Status { get; set; }

        public int ProjectPriority { get; set; }

        // Nullable fields
        #nullable enable
        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }
        public List<Task> Tasks { get; set; }
        #nullable disable
    }
}

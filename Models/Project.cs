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


        [Column(TypeName = "date")]
        public DateTime? CompletionDate { get; set; }

        public enum ProjectStatus
        {
            NotStarted,
            Active,
            Completed
        }

        public int ProjectPriority { get; set; }

        public List<Task> Tasks { get; set; }
    }
}

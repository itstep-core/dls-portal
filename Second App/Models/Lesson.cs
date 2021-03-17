using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Lesson
    {
        public int Id { get; set; }
        public int CourseId { get; set; }

        [Required]
        [StringLength(255)] 
        public string Name { get; set; }

        public virtual Course Course { get; set; }
        public virtual List<Chapter> Chapters { get; set; }        
    }
}

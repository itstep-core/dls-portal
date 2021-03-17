using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual List<Lesson> Lessons { get; set; }        
    }
}

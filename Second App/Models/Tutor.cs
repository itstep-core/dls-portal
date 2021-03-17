using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Tutor
    {
        public int TutorId { get; set; }

        [StringLength(50)] public string FullName { get; set; }

        public List<Course> Courses { get; set; }

        public virtual Course Course { get; set; }
    }
}

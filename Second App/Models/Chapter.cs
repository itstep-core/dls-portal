using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public int LessonId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual List<Material> Materials { get; set; }
    }
}

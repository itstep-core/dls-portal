using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Tutor
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Полное имя: ")]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Изображение: ")]
        [DataType(DataType.Upload)]
        public string ImagePath { get; set; }

        public virtual List<Course> Courses { get; set; }
    }
}

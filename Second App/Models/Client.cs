using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Полное имя: ")]
        public string FullName { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Изображение: ")]
        [DataType(DataType.Upload)]
        public string ImagePath { get; set; }

        [StringLength(50)]
        [Display(Name = "E-Mail: ")]
        public string Email { get; set; }
    }
}

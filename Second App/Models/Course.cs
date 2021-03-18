using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Название: ")]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Анотация: ")]
        public string About { get; set; }

        [Required]
        [StringLength(1024)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Описание: ")]
        public string Details { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Изображение: ")]
        [DataType(DataType.Upload)]
        public string ImagePath { get; set; }

        [Required]
        [Display(Name = "Планируемое количество уроков: ")]
        public int LessonsCount { get; set; }

        [Required]
        [Display(Name = "Планируемая длительность: ")]
        public int LessonsDuration { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Планируемое расписание: ")]
        public string Schedule { get; set; }

        [Required]
        [Display(Name = "Планируемая стоимость: ")]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        public int TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }

        public virtual List<Lesson> Lessons { get; set; }   
        public virtual List<Client> Clients { get; set; }
    }
}

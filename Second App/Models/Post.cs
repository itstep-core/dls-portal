using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required] public string ApplicationUserId { get; set; }
        [Required] [StringLength(256)] public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string About { get; set; }

        [DataType(DataType.Date)] public DataType PublishDate { get; set; }


        [Required(ErrorMessage = "You have not entered text of the comment yet.")]
        public string Full { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Picture: ")]
        public string ImagePath { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}

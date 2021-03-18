using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public int PostId { get; set; }
        public string ApplicationUserId { get; set; }
        [DataType(DataType.Date)] public DataType PublishDate { get; set; }


        [DataType(DataType.MultilineText)]
        [StringLength(256, ErrorMessage = "Allowed length is 256 symbols.")]
        [Display(Name = "Text of comment:")]
        [Required]
        public string Text { get; set; }

        public virtual Post Post { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}

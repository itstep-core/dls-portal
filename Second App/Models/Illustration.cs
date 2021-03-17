using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Illustration
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Signature: ")]


        public string Theory { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Picture: ")]
        public string ImagePath { get; set; }

        public string Title { get; set; }

        public virtual Material Material { get; set; }

        public virtual List<Illustration> Illustrations { get; set; }
    }
}

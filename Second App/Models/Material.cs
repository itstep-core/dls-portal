using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Material
    {
        public int Id { get; set; }

        public int ChapterId { get; set; }

        [Required]
        [StringLength(500)]
        [DataType(DataType.MultilineText)]

        public string Theory { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Video: ")]
        public string MediaPath { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Test: ")]
        public string TestPath { get; set; }


        [Required]
        [StringLength(70)]
        [Display(Name = "Key: ")]
        [DataType(DataType.Password)]
        public string TestKey { get; set; }

        public virtual Chapter Chapter { get; set; }
        public virtual List<Illustration> Illustrations { get; set; }
    }
}

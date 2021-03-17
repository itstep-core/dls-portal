using System.ComponentModel.DataAnnotations;

namespace Second_App.Models
{
    public class Client
    {
        public int Id { get; set; }

        [StringLength(50)] [Required] public string FullName { get; set; }

        [StringLength(50)] public string Email { get; set; }
    }
}

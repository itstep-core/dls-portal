using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Second_App.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual Tutor Tutor { get; set; }
        public virtual List<Post> Posts { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}

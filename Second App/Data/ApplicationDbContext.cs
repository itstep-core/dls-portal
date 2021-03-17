using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Second_App.Models;

namespace Second_App.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Illustration> Illustrations { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Tutor> Tutors { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}

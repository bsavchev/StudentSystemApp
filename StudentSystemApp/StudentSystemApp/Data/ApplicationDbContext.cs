using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using StudentSystemApp.Data.Domain;

namespace StudentSystemApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<Homework> Homeworks  { get; set; } = null!;
        public DbSet<Resource> Resources { get; set; } = null!;
        public DbSet<Student> Students { get; set; } = null!;

        public DbSet<StudentCourse> studentCourses { get; set; } = null!;

    }
}

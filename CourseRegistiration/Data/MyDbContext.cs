using CourseRegistiration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CourseRegistiration.Data
{
    public class MyDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
          base.OnModelCreating(modelBuilder);
        }
        public MyDbContext (DbContextOptions options) : base(options)
        {
        }
        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Enrollment> Enrollments { get; set; }
    }
}

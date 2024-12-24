using IMS_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace IMS_Project.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<UserRegistration> UserRegistration { get; set; }

        // Defining DbSet properties for the entities
        public DbSet<UserRegistration> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<Instructor> Instructors { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
using Test.Domain;

namespace Test.Infrastructure
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options){}

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}


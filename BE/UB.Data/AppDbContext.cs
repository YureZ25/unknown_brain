using Microsoft.EntityFrameworkCore;
using UB.Data.Domain;

namespace UB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<WelcomeForm> WelcomeForms { get; set; }
    }
}

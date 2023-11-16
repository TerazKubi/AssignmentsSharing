using AssignmentsSharing.Models;
using Microsoft.EntityFrameworkCore;

namespace AssignmentsSharing
{
    public class DataContext : DbContext
    {
        private IConfiguration _configuration;

        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }

        public DataContext(IConfiguration config)
        {
            _configuration = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_configuration.GetConnectionString("Sqlite"));
        }
    }
}

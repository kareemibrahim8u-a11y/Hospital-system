using Hospital_system.Models;
using Microsoft.EntityFrameworkCore;

namespace Hospital_system.Data
{
    public class AppdbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WIN-F6RQKLASJE;Database=G3ITIMVC;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}

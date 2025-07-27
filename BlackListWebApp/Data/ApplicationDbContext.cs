using BlackListWebApp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlackListWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BlackListPassenger> BlackListPassengers { get; set; }
        public DbSet<NonVisaPassenger> NonVisaPassengers { get; set; }
        public DbSet<INADReason> INADReasons { get; set; }
        public DbSet<Fine> Fines { get; set; }
    }
}

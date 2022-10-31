using AppEmployeeDb.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace AppEmployeeDb.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(SD.ConnectionString);
    }
}
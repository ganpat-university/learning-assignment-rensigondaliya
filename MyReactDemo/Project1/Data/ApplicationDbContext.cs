using Microsoft.EntityFrameworkCore;
using Project1.Models;

namespace Project1.Data
{
    public class ApplicationDbContext
        : DbContext
    {

        public DbSet<Department> Departments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
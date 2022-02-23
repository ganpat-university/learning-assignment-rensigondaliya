using Microsoft.EntityFrameworkCore;
using MyAegular.Models;
namespace MyAegular.Data
{
    public class ApplicationDbContext
        : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }
      
        public DbSet<Department> Departments { get; set; }
    }
}

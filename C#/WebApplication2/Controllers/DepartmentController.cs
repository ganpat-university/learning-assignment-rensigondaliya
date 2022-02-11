using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using System.Linq;

namespace WebApplication2.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var query = from dept in _context.Departments
                        select dept;

            return View(query);
        }
    }
}

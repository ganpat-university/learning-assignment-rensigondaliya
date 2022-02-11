using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return Ok("hello from rensi");
        }
    }
}

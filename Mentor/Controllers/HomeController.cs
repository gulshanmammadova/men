using Mentor.DataAccesLayer;
using Mentor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mentor.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
    
        public IActionResult Index()
        {
            List<Courses> courses=_context.courses.ToList();
            return View(courses);
        }
    }
}

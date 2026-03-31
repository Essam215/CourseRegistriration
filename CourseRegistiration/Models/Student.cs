using Microsoft.AspNetCore.Mvc;

namespace CourseRegistiration.Models
{
    public class Student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

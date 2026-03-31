using CourseRegistiration.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace CourseRegistiration.Controllers.Enrollment
{
    public class Enrollment : Controller
    {
        private readonly MyDbContext? _context;

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {

        }
        [HttpPost]

        public async Task<IActionResult> Register(Enrollment model)
        {

        }
    }
}

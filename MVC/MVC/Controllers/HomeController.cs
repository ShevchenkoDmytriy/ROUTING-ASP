using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Model;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db;
        public HomeController(ApplicationDbContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            var users = await db.users.ToListAsync();
            return View(users);
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> About(Users user)
        {
            db.users.Add(user);
            await db.SaveChangesAsync();
            return View("Index");
        }
    }
}

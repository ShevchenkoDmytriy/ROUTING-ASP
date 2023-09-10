
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Model;
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
        public async Task<IActionResult> About(string Name,int Age)
        {
            var newUser = new Users { Name = Name, Age = Age };
            db.users.Add(newUser);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
        }

    }
}

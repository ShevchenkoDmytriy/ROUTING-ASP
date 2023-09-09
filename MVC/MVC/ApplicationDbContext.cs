using Microsoft.EntityFrameworkCore;
using MVC.Model;

namespace MVC
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Users> users { get; set; } = null!;
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

    }

}

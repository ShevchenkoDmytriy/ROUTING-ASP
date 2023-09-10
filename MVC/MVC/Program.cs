using Microsoft.EntityFrameworkCore;
using MVC;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
string connection = builder.Configuration.GetConnectionString(name: "DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options=>options.UseSqlServer(connection));
var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");


app.Run();

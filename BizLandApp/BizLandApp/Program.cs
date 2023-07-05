var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    "default",
    "{controller=Home}/{action=Index}"
    );


app.Run();


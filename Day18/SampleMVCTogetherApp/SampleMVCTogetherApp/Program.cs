using Microsoft.EntityFrameworkCore;
using SampleMVCTogetherApp.Models;
using SampleMVCTogetherApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(opts =>
{
    opts.IdleTimeout = TimeSpan.FromMinutes(5);
});
string strCon = builder.Configuration.GetConnectionString("myCon");
builder.Services.AddDbContext<ShopContext>(opts =>
{
    opts.UseSqlServer(strCon);
});
//Injecting the service
builder.Services.AddScoped<IRepo<int, Customer>, CustomerRepo>();
builder.Services.AddScoped<IRepo<string, User>, UserRepo>();
builder.Services.AddScoped<LoginService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

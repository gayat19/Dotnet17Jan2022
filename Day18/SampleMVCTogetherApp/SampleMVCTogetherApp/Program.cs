using Microsoft.EntityFrameworkCore;
using SampleMVCTogetherApp.Models;
using SampleMVCTogetherApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
string strCon = builder.Configuration.GetConnectionString("myCon");
builder.Services.AddDbContext<ShopContext>(opts =>
{
    opts.UseSqlServer(strCon);
});
//Injecting the service
builder.Services.AddScoped<IRepo<int, Customer>, CustomerRepo>();
builder.Services.AddScoped<IAdding<string, User>, UserRepo>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews(opts=>opts.EnableEndpointRouting=false);
var app = builder.Build();
app.UseMvcWithDefaultRoute();

app.Run();

using DataAccess.Models;
using MCP1.Reposetery;
using MVP1.Entity;
using Microsoft.EntityFrameworkCore;
using MVCApps.CustomFilter;
using NuGet.Protocol.Plugins;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<Eshopping2Context>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<IDbRepository<Category, int>, CategoryRepository>();
builder.Services.AddScoped<IDbRepository<Product, int>, ProductRepositiry>();
//builder.Services.AddScoped<>
// Accept the Request for MVC and API Controllers
// For MVC Controllers this hels to Locate View to execute
//builder.Services.AddControllersWithViews();

builder.Services.AddControllersWithViews(options =>
{
    // Global REgistration of Action Filter
    options.Filters.Add(typeof(CustomLogRequestAttribute));
    // REgister the Exception Filter
    options.Filters.Add(typeof(AppExceptionAttribute));
});

// COnfigure The Session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options => {
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // SHow Error during Development these are standard Error MEssages
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
// MIddleware used to read/write Files on Server for Upload and Download
// By default this is used to read contents of 'wwwroot' folder
app.UseStaticFiles();
// CReate, LOad, and Exeute ROute Table for
// MVC Controller ROuting to execute 
// an Action Mathod of a COntrller class
app.UseRouting();
// USed in Case of Role BAsed Security

// USe the Session Middleware SO that, the HTTP Pipeline will use
// SessionId as Well as REad Data STored in Session
app.UseSession();

app.UseAuthorization();
// Map the Incomming HTTP Request URL to
// COrresponding COntroller and the Action Method from the Contrller
// {controller}/{action}/{id?}
// {controller}: The NAme of the COntroller in URL
// {action}: The Action Method from the Controller mentioned in URL
// {id?}: The Nullable Parameter which is a scalar type variable passed to Action MEthod
// e.g.
// http://MyServer/MyApp/MyController/MyAction
// {controller}---> MyController
// {action}---> MyAction

// THe DEfault mentioned here is
// {controller} is Home
// {action} is Idnex
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
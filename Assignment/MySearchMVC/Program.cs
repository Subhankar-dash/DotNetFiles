using MySearchMVC.DataAccess;
using MySearchMVC.Controllers;
using MySearchMVC.Models;
using MySearchMVC.Services;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Eshopping2Context>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection"));
});
builder.Services.AddScoped<iserv<ProductDetail>,Services>();



// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

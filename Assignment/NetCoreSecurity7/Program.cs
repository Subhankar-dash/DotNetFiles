using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NetCoreSecurity7.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("NetCoreSecurity7ContextConnection") ?? throw new InvalidOperationException("Connection string 'NetCoreSecurity7ContextConnection' not found.");

builder.Services.AddDbContext<NetCoreSecurity7Context>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<NetCoreSecurity7Context>();

builder.Services.AddDbContext<NetCoreSecurity7Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("NetCoreSecurity7ContextConnection"));
});



// Register a Service for executing RAzor Views used for Identity
// this is used when AddIdentity<TUser,TRole>() method is used for
// Security
builder.Services.AddRazorPages();


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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


// Lets Support request processing for RAzor Views
// (Those are added with the Identity Scaffolded Items)
app.MapRazorPages();

app.Run();

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Security.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SecurityContextConnection") ?? throw new InvalidOperationException("Connection string 'SecurityContextConnection' not found.");

builder.Services.AddDbContext<SecurityContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<SecurityContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SecurityContextConnection"));
});

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<SecurityContext>();


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

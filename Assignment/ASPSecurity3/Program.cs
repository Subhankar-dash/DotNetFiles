using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASPSecurity3.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ASPSecurity3ContextConnection") ?? throw new InvalidOperationException("Connection string 'ASPSecurity3ContextConnection' not found.");

builder.Services.AddDbContext<ASPSecurity3Context>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//  .AddEntityFrameworkStores<ASPSecurity3Context>();

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//  .AddEntityFrameworkStores<ASPSecurity2Context>();

// THe Service REgistration in Dependency COntainer for Following classes
// 1. USerManager<IdentityUser>
// 2. SignInManager<IdentityUser>

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
// AddDefaultIdentity<IdentityUser>() for the USer Based Authentication
// SignIn.RequireConfirmedAccount = true The Email MUST be Verified
// AddEntityFrameworkStores<SecurityCodi>();: Read USers Information using
// EF Core
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ASPSecurity3Context>();


builder.Services.AddDbContext<ASPSecurity3Context>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("ASPSecurity3ContextConnection"));
});


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

app.Run();

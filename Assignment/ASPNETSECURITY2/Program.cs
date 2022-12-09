using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ASPNETSECURITY2.Data;
using ASPNETSECURITY2.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("ASPNETSECURITY2ContextConnection") ?? throw new InvalidOperationException("Connection string 'ASPNETSECURITY2ContextConnection' not found.");

builder.Services.AddDbContext<ASPNETSECURITY2Context>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<ASPNETSECURITY2User>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<ASPNETSECURITY2Context>();

builder.Services.AddDbContext<ASPNETSECURITY2Context>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("ASPNETSECURITY2ContextConnection"));
});


// THe Service REgistration in Dependency COntainer for Following classes
// 1. USerManager<IdentityUser>
// 2. SignInManager<IdentityUser>

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true);
// AddDefaultIdentity<IdentityUser>() for the USer Based Authentication
// SignIn.RequireConfirmedAccount = true The Email MUST be Verified
// AddEntityFrameworkStores<SecurityCodi>();: Read USers Information using
// EF Core
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false);

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

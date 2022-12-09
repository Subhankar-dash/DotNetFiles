using ASPNETSECURITY2.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNETSECURITY2.Data;

public class ASPNETSECURITY2Context : IdentityDbContext<ASPNETSECURITY2User>
{
    public ASPNETSECURITY2Context(DbContextOptions<ASPNETSECURITY2Context> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}

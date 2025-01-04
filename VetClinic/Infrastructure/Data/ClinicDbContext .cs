using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class ClinicDbContext
    : IdentityDbContext<IdentityUser<Guid>, 
        IdentityRole<Guid>, 
        Guid, 
        IdentityUserClaim<Guid>, 
        IdentityUserRole<Guid>, 
        IdentityUserLogin<Guid>, 
        IdentityRoleClaim<Guid>, 
        IdentityUserToken<Guid>>
{
    public ClinicDbContext(DbContextOptions<ClinicDbContext> options)
        : base(options)
    {
    }
}

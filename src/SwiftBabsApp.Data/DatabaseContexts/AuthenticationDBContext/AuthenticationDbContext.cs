using SwiftBabsApp.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace SwiftBabsApp.Data.DatabaseContext.AuthenticationDBContext
{

     public class AuthenticationDbContext : IdentityDbContext<ApplicationUser>
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
        : base(options)
        {
        }
    }
}
using Microsoft.EntityFrameworkCore;
using SwiftBabsApp.Data.Entities;

namespace SwiftBabsApp.Data.DatabaseContext.ApplicationDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Property> Properties { get; set;}
        public DbSet<Contact> Contacts { get; set;}
        
    }
}
using DotNet_Azure_App_1.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_Azure_App_1.Data
{
    public class AzureApplicationDbContext : DbContext
    {
        public AzureApplicationDbContext(DbContextOptions<AzureApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AzureUser> AzureUsers =>Set<AzureUser>();
    }
}

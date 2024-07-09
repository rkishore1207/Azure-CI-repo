using Microsoft.EntityFrameworkCore;

namespace AzureContinuousIntegration.DataAccessLayer
{
    public class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions<AzureDbContext> options) : base(options)
        {
            
        }

        public DbSet<Person> Persons { get; set; }
    }
}

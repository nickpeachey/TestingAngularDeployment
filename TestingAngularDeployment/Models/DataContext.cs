using Microsoft.EntityFrameworkCore;

namespace TestingAngularDeployment.Models
{
    public class DataContext : DbContext
    {
        public DbSet<AppUserAuth> AppUserAuths { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
    }
}

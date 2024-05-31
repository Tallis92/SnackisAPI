using Microsoft.EntityFrameworkCore;

namespace SnackisAPI.DAL
{
    public class DbContextAPI : DbContext
    {
     
        public DbContextAPI(DbContextOptions<DbContextAPI> options)
        : base(options)
        {
        }

        public DbSet<Models.Category> Categories { get; set; }
        
    }
}

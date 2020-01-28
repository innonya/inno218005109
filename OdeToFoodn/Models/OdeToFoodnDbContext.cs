using Microsoft.EntityFrameworkCore;

namespace OdeToFoodn.Models
{
    public class OdeToFoodnDbContext : DbContext
    {
        
        public OdeToFoodnDbContext(DbContextOptions<OdeToFoodnDbContext> options) : base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}
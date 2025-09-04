using Microsoft.EntityFrameworkCore;

namespace NorthwindDB
{
    public class NorthwindContext : DbContext
    {
        public NorthwindContext(DbContextOptions<NorthwindContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}

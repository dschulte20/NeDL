using Microsoft.EntityFrameworkCore;

namespace GuitarApi.Models
{
    public class GuitarContext : DbContext
    {
        public GuitarContext(DbContextOptions<GuitarContext> options)
            : base(options)
        {
        }

        public DbSet<GuitarItem> GuitarItems { get; set; }
    }
}

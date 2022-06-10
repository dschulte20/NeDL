using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
namespace GuitarComp.Models
{
    public class GuitarContext : DbContext
    {
        public GuitarContext(DbContextOptions<GuitarContext> options)
            : base(options)
        {
        }

        public DbSet<GuitarItem> GuitarItems { get; set; } = null!;
    }
}

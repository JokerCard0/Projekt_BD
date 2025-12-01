using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class SprzetDbContext : DbContext
    {
        public SprzetDbContext(DbContextOptions<SprzetDbContext> options) :base (options){}

        public DbSet<Sprzet> Sprzet_ {  get; set; }
    }
}

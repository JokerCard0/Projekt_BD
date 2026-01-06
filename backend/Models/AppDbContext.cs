using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace backend.Models
{
    public class AppDbContext : IdentityDbContext<Admin>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Sprzet> Sprzety {  get; set; }
        public DbSet<Adres> Adresy { get; set; }
        public DbSet<Klient> Klienci { get; set; }
        public DbSet<Wypozyczenie> Wypozyczenia { get; set; }
        public DbSet<Admin> Admini { get; set; }
        public DbSet<Opinia> Opinie { get; set; }  
    }
}

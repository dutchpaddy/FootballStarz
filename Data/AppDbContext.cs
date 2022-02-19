using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FootballStarz.Models;

namespace FootballStarz.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { 
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}

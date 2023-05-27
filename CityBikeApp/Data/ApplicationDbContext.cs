using CityBikeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CityBikeApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {

        }  

        public DbSet<Station> Stations { get; set; }

        
    }
}

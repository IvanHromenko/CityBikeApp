using CityBikeApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityBikeApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {

        }  

        public DbSet<Station> Stations { get; set; }
        public DbSet<Trip> Trips { get; set; }


    }
}

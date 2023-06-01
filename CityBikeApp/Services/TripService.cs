using CityBikeApp.Data;
using CityBikeApp.Models.Entities;

namespace CityBikeApp.Services
{
    public class TripService
    {
        private ApplicationDbContext _db;
        public TripService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Trip> GetAllTrips()
        {
            return _db.Trips.ToList();
        }
    }
}

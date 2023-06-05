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

        public List<Trip> GetPagedTrips(int page, int pageSize)
        {
            return _db.Trips
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }
        public int GetTotalPages(int pageSize)
        {
            int totalRecords = _db.Trips.Count();
            return (int)Math.Ceiling((double)totalRecords / pageSize);
        }
    }
}

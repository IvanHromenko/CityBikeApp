using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Services.IServices;

namespace CityBikeApp.Services
{
    public class TripService : Service<Trip>, ITripService
    {
        private ApplicationDbContext _db;
        public TripService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}

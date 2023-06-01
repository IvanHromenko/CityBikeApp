using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Services.IServices;

namespace CityBikeApp.Services
{
    public class StationService : Service<Station>, IStationService
    {
        private ApplicationDbContext _db;
        public StationService(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

    }
}

using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Models.Entities;

namespace CityBikeApp.Services
{
    public class StationService
    {
        private readonly ApplicationDbContext _db;
        public StationService(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<Station> GetAllStations()
        {
            return _db.Stations.ToList();
        }

        public void CreateStation(Station station)
        {
            _db.Stations.Add(station);
            _db.SaveChanges();
        }

        public Station GetStationById(short id)
        {
            return _db.Stations.Find(id);
        }

    }
}

using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Services.IServices;

namespace CityBikeApp.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Station = new StationService(_db);
            Trip = new TripService(_db);
        }

        public IStationService Station { get; private set; }
        public ITripService Trip { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

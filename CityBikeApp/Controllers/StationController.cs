using CityBikeApp.Data;
using CityBikeApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityBikeApp.Controllers
{
    public class StationController : Controller
    {
        private readonly ApplicationDbContext _db;
        public StationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Station> objStationList = _db.Stations.ToList();
            return View(objStationList);
        }
    }
}

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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Station obj)
        {
            if (ModelState.IsValid)
            {
                _db.Stations.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index", "Station");
            }
            return View();
        }

        public IActionResult Details(short id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            Station stationFromDB = _db.Stations.Find(id);
            if (stationFromDB == null)
            {
                return NotFound();
            }
            return View(stationFromDB);
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Station> objStationList = _db.Stations.ToList();
            return Json(new {data = objStationList });
        }

        #endregion
    }
}

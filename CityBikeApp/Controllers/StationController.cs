using CityBikeApp.Data;
using CityBikeApp.Models.Entities;
using CityBikeApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityBikeApp.Controllers
{
    public class StationController : Controller
    {
        private readonly StationService _stationService;
        public StationController(StationService stationService)
        {
            _stationService = stationService;
        }
        public IActionResult Index()
        {
            List<Station> objStationList = _stationService.GetAllStations();
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
                _stationService.CreateStation(obj);
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
            Station stationFromDB = _stationService.GetStationById(id);
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
            List<Station> objStationList = _stationService.GetAllStations();
            return Json(new {data = objStationList });
        }

        #endregion
    }
}

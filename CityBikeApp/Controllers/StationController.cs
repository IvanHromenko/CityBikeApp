using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Services;
using CityBikeApp.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace CityBikeApp.Controllers
{
    public class StationController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public StationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Station> objStationList = _unitOfWork.Station.GetAll();
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
                _unitOfWork.Station.Create(obj);
                _unitOfWork.Save();
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
            Station stationFromDB = _unitOfWork.Station.Get(id);
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
            List<Station> objStationList = _unitOfWork.Station.GetAll();
            return Json(new {data = objStationList });
        }

        #endregion
    }
}

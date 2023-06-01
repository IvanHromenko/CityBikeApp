using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CityBikeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;


        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            List<Trip> tripList = _unitOfWork.Trip.GetAll();
            return View(tripList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Trip obj)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Trip.Create(obj);
                _unitOfWork.Save();
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetTrips()
        {
            List<Trip> objTripList = _unitOfWork.Trip.GetAll();
            return Json(new { data = objTripList });
        }

        #endregion
    }
}
using CityBikeApp.Data;
using CityBikeApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CityBikeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;


        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            List<Trip> tripList = _db.Trips.ToList();
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
                _db.Trips.Add(obj);
                _db.SaveChanges();
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
            List<Trip> objTripList = _db.Trips.ToList();
            return Json(new { data = objTripList });
        }

        #endregion
    }
}
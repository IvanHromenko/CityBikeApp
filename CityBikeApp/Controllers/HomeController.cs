using CityBikeApp.Data;
using CityBikeApp.Models;
using CityBikeApp.Models.Entities;
using CityBikeApp.Models.ViewModels;
using CityBikeApp.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CityBikeApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly TripService _tripService;


        public HomeController(ILogger<HomeController> logger, TripService tripService)
        {
            _logger = logger;
            _tripService = tripService;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 10;
            TripsViewModel viewModel = new TripsViewModel
            {
                Trips = _tripService.GetPagedTrips(page, pageSize),
                CurrentPage = page,
                TotalPages = _tripService.GetTotalPages(pageSize)
            };
            
            return View(viewModel);
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
            List<Trip> objTripList = _tripService.GetAllTrips();
            return Json(new { data = objTripList });
        }

        #endregion
    }
}
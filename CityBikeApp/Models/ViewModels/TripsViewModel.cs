using CityBikeApp.Models.Entities;

namespace CityBikeApp.Models.ViewModels
{
    public class TripsViewModel
    {
        public List<Trip> Trips { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}

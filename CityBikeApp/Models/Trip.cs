using System.ComponentModel.DataAnnotations;

namespace CityBikeApp.Models
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Return { get; set; }
        public short DepartureStationId { get; set; }
        public string DepartureStationName { get; set; }
        public short ReturnStationId { get; set; }
        public string ReturnStationName { get; set; }
        public int CoveredDistanceM { get; set; }
        public int DurationSec { get; set; }


    }
}

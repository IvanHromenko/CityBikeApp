using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CityBikeApp.Models.Entities
{
    public class Trip
    {
        [Key]
        public int Id { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Return { get; set; }
        [Required]
        public short DepartureStationId { get; set; }

        public string DepartureStationName { get; set; }
        [Required]
        public short ReturnStationId { get; set; }

        public string ReturnStationName { get; set; }
        public int CoveredDistanceM { get; set; }
        public int DurationSec { get; set; }


    }
}

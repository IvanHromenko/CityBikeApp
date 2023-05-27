using System.ComponentModel.DataAnnotations;

namespace CityBikeApp.Models
{
    public class Station
    {
        [Key]
        public short Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}

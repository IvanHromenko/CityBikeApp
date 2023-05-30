using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CityBikeApp.Models
{
    public class Station
    {
        [Key]
        public short ID { get; set; }
        [Required]
        [DisplayName("Station Name")]
        public string Name { get; set; }
        public string Adress { get; set; }
        public short Capacity { get; set; }
        public Double x { get; set; }
        public Double y { get; set; }
    }
}

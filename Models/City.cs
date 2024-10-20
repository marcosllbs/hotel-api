namespace HotelAPI.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;

    // 1. Implemente as models da aplicação
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string? Name { get; set; }

        public ICollection<Hotel> Hotels { get; set; }
    }
}
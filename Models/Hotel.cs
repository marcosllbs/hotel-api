namespace HotelAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// 1. Implemente as models da aplicação
public class Hotel
{
    [Key]
    public int HotelId { get; set; }
    public string? Name { get; set; }
    public string? Adress { get; set; }
    [ForeignKey("CityId")]
    public int CityId { get; set; }
}
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Flight
    {
        [Key]
        public string FlightID { get; set; }
        public DateTime? Date { get; set; }  
        public string? Loading { get; set; }
        public string? UnLoading { get; set; }

    }
}

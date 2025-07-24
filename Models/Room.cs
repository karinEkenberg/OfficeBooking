using System.ComponentModel.DataAnnotations;

namespace OfficeBooking.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Booking>? Bookings { get; set; }
    }
}

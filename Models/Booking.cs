using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeBooking.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public Room? Room { get; set; }
    }
}

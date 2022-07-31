using Library.API.Models;

namespace Library.API.DTO
{
    public class ReservationDTO
    {
        public int ReservationId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime StartReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public string? Note { get; set; }

    }
}

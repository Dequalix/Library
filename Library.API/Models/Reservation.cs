using Library.API.DTO;
using Library.API.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.API
{
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Book Book { get; set; }

        [Required]
        public User User { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartReservation { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndReservation { get; set; }

        public string? Note { get; set; }

    }
}
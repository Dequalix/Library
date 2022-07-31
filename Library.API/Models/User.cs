using System.ComponentModel.DataAnnotations;

namespace Library.API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? Adres { get; set; }
        public string? ZipCode { get; set; }
        public string? City { get; set; }

    }
}

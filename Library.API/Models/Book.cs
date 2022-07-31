using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.API.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Published { get; set; }
    }
}

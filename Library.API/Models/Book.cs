using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.API.Models
{
    [Table("Book")]
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        public string Language { get; set; }

        public virtual BooksInStock Stock { get; set; }

        [Required]
        public int Year { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.API.Models
{
    public class BooksInStock
    {
        [Key]
        [ForeignKey("Book")]
        public int BookId { get; set; }

        public int? TotalStock { get; set; }
        public virtual Book Book { get; set; }     


    }
}

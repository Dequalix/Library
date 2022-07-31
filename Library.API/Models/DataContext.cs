using Library.API.Models;
using Microsoft.EntityFrameworkCore;



namespace Library.API
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }

    
    }
}
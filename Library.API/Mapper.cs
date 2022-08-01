using Library.API.DTO;
using Library.API.Models;

namespace Library.API
{
    public static class Mapper
    {
        public static Book ToBook(BookDTO dto)
        {
            return new Book
            {
                Author = dto.Author,
                Title = dto.Title,
                Year = dto.Year,
                Id = dto.BookId,
                Language = dto.Language,
                Pages = dto.Pages,
                Stock = new BooksInStock() { TotalStock = dto.InStock, BookId = dto.BookId}
            };
        }

        public static BookDTO ToBookDto(Book model)
        {
            return new BookDTO
            {
                Author = model.Author,
                Title = model.Title,
                Year = model.Year,
                BookId = model.Id,
                Language = model.Language,
                Pages = model.Pages,
                InStock = model.Stock.TotalStock.GetValueOrDefault()                
            };
        }

        public static BooksInStock ToBookInStockDto(BooksInStock model)
        {
            return new BooksInStock
            {
                BookId = model.BookId,
                TotalStock = model.TotalStock              
            };
        }

        public static BooksInStockDTO ToBookInStock(BooksInStock dto)
        {
            return new BooksInStockDTO
            {
                BookId = dto.BookId,
                TotalStock = dto.TotalStock
            };
        }

        public static User ToUser(UserDTO dto)
        {
            return new User
            {
                Id = dto.UserId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                DateOfBirth = dto.DateOfBirth,
                Email = dto.Email,
                ZipCode = dto.ZipCode,
                City = dto.City,
                Adres = dto.Adres
            };
        }
        public static UserDTO ToUserDto(User model)
        {
            return new UserDTO
            {
                UserId = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                DateOfBirth = model.DateOfBirth,
                Email = model.Email,
                ZipCode = model.ZipCode,
                City = model.City,
                Adres = model.Adres
            };
        }

        public static ReservationDTO ToReservationDto(Reservation model)
        {
            return new ReservationDTO 
            {
                ReservationId = model.Id,
                BookId = model.Book.Id,
                UserId = model.User.Id,
                StartReservation = model.StartReservation,
                EndReservation = model.EndReservation,
                Note = model.Note
            };

        }

        public static Reservation ToReservation(ReservationDTO dto)
        {
            return new Reservation
            {
                Id = dto.ReservationId,
                Book = new Book() { Id = dto.BookId },
                User = new User() { Id = dto.UserId },
                StartReservation = dto.StartReservation,
                EndReservation = dto.EndReservation,
                Note = dto.Note
            };
        }

    }
}

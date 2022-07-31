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
                Title = dto.Title,
                Published = dto.Published,
                Id = dto.BookId
            };
        }

        public static BookDTO ToBookDto(Book model)
        {
            return new BookDTO
            {
                Title = model.Title,
                Published = model.Published,
                BookId = model.Id
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

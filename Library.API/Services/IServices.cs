using Library.API.DTO;
using Library.API.Models;

namespace Library.API.Services
{
    public interface IServices
    {
        List<BookDTO> FindBook(string search);
        List<BookDTO> Booklist();
        void SaveBook(List<BookDTO> book);
        List<ReservationDTO> FindReservation(string search);
        List<ReservationDTO> ReservationList();
        void SaveReservation(List<ReservationDTO> reservations);
        List<UserDTO> UserList();
        List<UserDTO> FindUser(string search);
        void SaveUser(List<UserDTO> user);
    }
}

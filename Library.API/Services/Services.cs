using Library.API.DTO;
using Library.API.Repositories;


namespace Library.API.Services
{
    public class Services : IServices
    {
        private readonly IUserRepository _userRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IReservationRepository _reservationRepository;

        public Services(IUserRepository userRepository, 
            IBookRepository bookRepository, 
            IReservationRepository reservationRepository)
        {
            _userRepository = userRepository;
            _bookRepository = bookRepository;   
            _reservationRepository = reservationRepository;
        }

        public List<BookDTO> FindBook(string search)
        {
            return _bookRepository
                .Find(search)
                .Select(Mapper.ToBookDto)
                .ToList();
        }

        public List<BookDTO> Booklist()
        {
            return _bookRepository
                .List()
                .Select(Mapper.ToBookDto)
                .ToList();
        }

        public void SaveBook(List<BookDTO> bookDTOs)
        {
            bookDTOs.ForEach(dto => _bookRepository
            .SaveBook(Mapper.ToBook(dto)));
        }

        public List<ReservationDTO> FindReservation(string search)
        {
            return _reservationRepository
                .Find(search)
                .Select(reservation => Mapper.ToReservationDto(reservation))
                .ToList();
        }

        public List<ReservationDTO> ReservationList()
        {
            return _reservationRepository
                .List()
                .Select(reservation => Mapper.ToReservationDto(reservation))
                .ToList();
        }

        public void SaveReservation(List<ReservationDTO> reservations)
        {
            reservations
                .ForEach(reservation => this._reservationRepository
                .SaveReservation(Mapper.ToReservation(reservation)));
        }

        public List<UserDTO> UserList()
        {
            return _userRepository
                .List().Select((user) => Mapper.ToUserDto(user))
                .ToList();
        }

        public List<UserDTO> FindUser(string search)
        {
            return _userRepository
                .Find(search).Select((user) => Mapper.ToUserDto(user))
                .ToList();
        }

        public void SaveUser(List<UserDTO> userList)
        {
            userList.ForEach(user => _userRepository.SaveUser(Mapper.ToUser(user)));
        }
    }
}

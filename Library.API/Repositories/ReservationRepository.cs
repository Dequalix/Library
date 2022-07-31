using Library.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.API.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly DataContext dataContext;
        public ReservationRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Reservation> List()
        {
            return dataContext.Reservations
                .Include(x => x.Book)
                .Include(x => x.User)
                .ToList();
        }

        public List<Reservation> SearchOnBook(string bookName)
        {
            return dataContext.Reservations
                .Include(x => x.Book)
                .Include(x => x.User)
                .Where(x => x.Book.Title.Contains(bookName)).ToList();
        }
        
        public List<Reservation> SearchOnUser(string name)
        {
            return dataContext.Reservations
                .Include(x => x.Book)
                .Include(x => x.User)
                .Where(x => x.User.FirstName.Contains(name) || x.User.LastName.Contains(name)).ToList();
        }

        public void SaveReservation (Reservation reservation)
        {
            dataContext.Reservations.Add(reservation);
            dataContext.SaveChanges();
        }
    }
}

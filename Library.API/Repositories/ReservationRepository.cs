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

        public List<Reservation> Find(string search)
        {
            return dataContext.Reservations
                .Include(x => x.Book)
                .Include(x => x.User)
                .Where(x => x.Book.Title.Contains(search)
                || x.User.FirstName.Contains(search)
                || x.User.LastName.Contains(search)).ToList();
        }

        public void SaveReservation (Reservation reservation)
        {
            dataContext.Reservations.Add(reservation);
            dataContext.SaveChanges();
        }
    }
}

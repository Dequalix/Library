namespace Library.API.Repositories
{
    public interface IReservationRepository
    {
        List<Reservation> List();
        List<Reservation> SearchOnBook(string bookName);
        List<Reservation> SearchOnUser(string name);
        void SaveReservation(Reservation reservation);
    }
}

namespace Library.API.Repositories
{
    public interface IReservationRepository
    {
        List<Reservation> List();
        List<Reservation> Find(string search);
        void SaveReservation(Reservation reservation);
    }
}

using Library.API.Models;

namespace Library.API.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dataContext;

        public UserRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<User> List()
        {
            return dataContext.Users.ToList();
        }
        public List<User> FindUserByFirstName(string firstName)
        {
            return dataContext.Users.Where(user => user.FirstName.Contains(firstName)).ToList();
        }

        public List<User> FindUserByLastName(string lastName)
        {
            return dataContext.Users.Where(user => user.LastName.Contains(lastName)).ToList();  
        }

        public List<User> FindUserByAdres(string adres)
        {
            return dataContext.Users.Where(user => user.Adres.Contains(adres)).ToList();
        }

        public void SaveUser(User user)
        {
            dataContext.Add(user);
            dataContext.SaveChanges();
        }
    }
}

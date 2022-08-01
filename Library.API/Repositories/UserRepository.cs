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
        public List<User> FindUserByName(string name)
        {
            return dataContext.Users.Where(user => user.FirstName.Contains(name) || user.LastName.Contains(name)).ToList();
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

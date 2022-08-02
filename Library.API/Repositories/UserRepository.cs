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
        public List<User> Find(string input)
        {
            return dataContext.Users
                .Where(user => user.FirstName.Contains(input) || 
                    user.LastName.Contains(input) || 
                    user.Email.Contains(input) ||
                    user.Adres.Contains(input))
                .ToList();
        }

        public void SaveUser(User user)
        {
            dataContext.Add(user);
            dataContext.SaveChanges();
        }
    }
}

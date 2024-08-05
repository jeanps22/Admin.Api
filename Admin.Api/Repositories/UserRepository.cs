using Admin.Api.Model;
using Admin.Api.Repositories.Interfaces;

namespace Admin.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users;

        public UserRepository()
        {
            _users = new List<User>
            { 
                new() { UserName = "Xavier", Password = "Xavier", Role = "Manager"}, 
                new() { UserName = "Logan", Password = "Logan", Role = "Eployee"}
            };
        }
        public User? GetByUserName(string userName)
        {
           return _users.FirstOrDefault(x => x.UserName == userName);
        }
    }
}

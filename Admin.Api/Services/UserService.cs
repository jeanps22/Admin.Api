using Admin.Api.Model;
using Admin.Api.Repositories.Interfaces;

namespace Admin.Api.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User? GetByUserName(string userName)
        {
            return _userRepository.GetByUserName(userName);
        }
    }
}

using Admin.Api.Model;

namespace Admin.Api.Repositories.Interfaces
{
    public interface IUserRepository
    {
        User? GetByUserName(string userName);
    }
}

using Admin.Api.Model;

namespace Admin.Api.Repositories.Interfaces
{
    public interface IUserService
    {
        User? GetByUserName(string userName);
    }
}

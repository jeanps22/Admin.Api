using Admin.Api.Dtos;
using Admin.Api.Model;

namespace Admin.Api.Services.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(LoginDto user);
    }
}

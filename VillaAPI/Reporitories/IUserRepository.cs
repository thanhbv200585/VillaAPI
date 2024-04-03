using VillaAPI.Models;
using VillaAPI.Models.Dto;

namespace VillaAPI.Reporitories
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDto> Login(LoginRequestDto loginRequestDto);
        Task<LocalUser> Register(RegisterRequestDto registerRequestDto);
    }
}

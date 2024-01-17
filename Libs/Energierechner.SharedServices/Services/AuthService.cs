using Energierechner.SharedModels.DTOs;
using Energierechner.SharedServices.Services.IServices;

namespace Energierechner.SharedServices.Services;

public class AuthService : IAuthService
{
    private readonly IBaseService _baseService;

    public AuthService(IBaseService baseService)
    {
        _baseService = baseService;
    }




    public Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto> DeleteUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto> EditUserAsync(UserDto userDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto?> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto)
    {
        throw new NotImplementedException();
    }
}

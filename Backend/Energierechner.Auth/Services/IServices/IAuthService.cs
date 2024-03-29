using Energierechner.SharedModels.DTOs;

namespace Energierechner.Auth.Services.IServices;

public interface IAuthService
{
    Task<ResponseDto> EditUserAsync(UserDto userDto);
    Task<ResponseDto> RegisterAsync(RegisterRequestDto registerRequestDto);
    Task<ResponseDto> LoginAsync(LoginRequestDto loginRequestDto);
    Task<ResponseDto> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto);
    Task<ResponseDto> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);
    Task<bool> AssignRoleAsync(string email, string roleName);
}
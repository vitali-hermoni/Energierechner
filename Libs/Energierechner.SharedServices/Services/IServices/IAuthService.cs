using Energierechner.SharedModels.DTOs;

namespace Energierechner.SharedServices.Services.IServices;

public interface IAuthService
{
    Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto);
    Task<ResponseDto?> RegisterAsync(RegisterRequestDto registerRequestDto);
    Task<ResponseDto?> ForgotPasswordAsync(ForgotPasswordDto forgotPasswordDto);
    Task<ResponseDto?> ResetPasswordAsync(ResetPasswordRequestDto resetPasswordRequestDto);
    Task<ResponseDto?> AssignRoleAsync(RegisterRequestDto registerRequestDto);
    Task<ResponseDto> EditUserAsync(UserDto userDto);
    Task<ResponseDto> DeleteUserByIdAsync(Guid id);
}

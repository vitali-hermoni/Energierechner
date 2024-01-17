namespace Energierechner.SharedModels.DTOs;

public record LoginResponseDto(
    UserDto? UserDto = null,
    string? Token = null)
{

}

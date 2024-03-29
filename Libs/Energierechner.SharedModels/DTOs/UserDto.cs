namespace Energierechner.SharedModels.DTOs;

public record UserDto(
    Guid? Id,
    string Email,
    string Name,
    string PhoneNumber,
    Guid? IdentKey = null)
{

}

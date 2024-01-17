using System.ComponentModel.DataAnnotations;

namespace Energierechner.SharedModels.DTOs;

public record ForgotPasswordDto()
{
    [Required(ErrorMessage = "E-Mail ist erforderlich")]
    [EmailAddress]
    public string Email { get; init; }
}

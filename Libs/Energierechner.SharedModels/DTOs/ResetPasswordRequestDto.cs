using System.ComponentModel.DataAnnotations;

namespace Energierechner.SharedModels.DTOs;

public record ResetPasswordRequestDto
{
    [Required(ErrorMessage = "E-Mail ist erforderlich")]
    [EmailAddress]
    public string Email { get; init; } = string.Empty;


    [Required(ErrorMessage = "Passwort ist erforderlich")]
    [StringLength(100, ErrorMessage = "Minimum {0} Zeichen.", MinimumLength = 8)]
    [DataType(DataType.Password)]
    public string Password { get; init; } = string.Empty;

    [Required(ErrorMessage = "Passwort ist erforderlich")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Die Passwörter stimmen nicht überein.")]
    public string ConfirmPassword { get; init; } = string.Empty;

    public string Code { get; init; } = string.Empty;
}

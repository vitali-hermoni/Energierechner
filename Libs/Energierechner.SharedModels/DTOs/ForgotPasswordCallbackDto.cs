namespace Energierechner.SharedModels.DTOs;

public record ForgotPasswordCallbackDto(string UserId, string Code, string UserMail)
{

}

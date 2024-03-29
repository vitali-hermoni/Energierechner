namespace Energierechner.SharedServices.Services.IServices;

public interface ITokenProvider
{
    void SetToken(string token);
    string? GetToken();
    void ClearToken();
}

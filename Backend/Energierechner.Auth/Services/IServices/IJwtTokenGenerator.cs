using Energierechner.Auth.Models;

namespace Energierechner.Auth.Services.IServices;

public interface IJwtTokenGenerator
{
    string GenerateToken(AppUser appUser, IEnumerable<string> roles);
}
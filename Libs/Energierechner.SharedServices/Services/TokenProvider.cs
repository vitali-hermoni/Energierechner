using Energierechner.SharedModels.Utilities;
using Energierechner.SharedServices.Services.IServices;
using Microsoft.AspNetCore.Http;

namespace Energierechner.SharedServices.Services;

public class TokenProvider : ITokenProvider
{
    private readonly IHttpContextAccessor _contextAccessor;



    public TokenProvider(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }


    public void ClearToken()
    {
        _contextAccessor.HttpContext?.Response.Cookies.Delete(ConstStrings.TokenCookie);
    }


    public string? GetToken()
    {
        string? token = null;
        bool? hasToken = _contextAccessor.HttpContext?.Request.Cookies.TryGetValue(ConstStrings.TokenCookie, out token);
        return hasToken is true ? token : null;
    }


    public void SetToken(string token)
    {
        _contextAccessor.HttpContext?.Response.Cookies.Append(ConstStrings.TokenCookie, token);
    }
}

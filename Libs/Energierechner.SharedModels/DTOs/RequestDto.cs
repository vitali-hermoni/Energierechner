using Energierechner.SharedModels.Enums;
using System.Net.Mime;
using System.Security.AccessControl;
using ContentType = Energierechner.SharedModels.Enums.ContentType;

namespace Energierechner.SharedModels.DTOs;

public record RequestDto(
    ApiType ApiType,
    string Url,
    object? Data,
    string? AccessToken,
    ContentType? ContentType = ContentType.Json)
{

}

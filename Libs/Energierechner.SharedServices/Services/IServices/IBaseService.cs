using Energierechner.SharedModels.DTOs;

namespace Energierechner.SharedServices.Services.IServices;

public interface IBaseService
{
    Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
}

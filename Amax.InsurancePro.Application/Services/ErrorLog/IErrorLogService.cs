
using Amax.InsurancePro.Application.Dtos;

namespace Amax.InsurancePro.Application.Services;

public interface IErrorLogService
{
    public Task<ErrorLogDto> Log(ErrorLogDto request);
}

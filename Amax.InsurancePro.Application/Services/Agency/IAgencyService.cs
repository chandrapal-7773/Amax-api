using Amax.InsurancePro.Application.Dtos;

namespace Amax.InsurancePro.Application.Services;
public interface IAgencyService
{
	Task<AgencyDto> Get(long id);
	Task<AgenciesDto> GetAll(TableParameterDto request);
	Task<ResultDto> Add(AgencyDto request, long userId, string loginId);
	Task<ResultDto> Update(AgencyDto request, long userId, string loginId);
	Task<ResultDto> Delete(long id, long userId, string loginId);
}

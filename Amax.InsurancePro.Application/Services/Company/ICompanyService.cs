using Amax.InsurancePro.Application.Dtos;

namespace Amax.InsurancePro.Application.Services;
public interface ICompanyService
{
	Task<CompanyDto> Get(long id);
	Task<CompaniesDto> GetAll(TableParameterDto request);
	Task<ResultDto> Add(CompanyDto request, long userId, string loginId);
	Task<ResultDto> Update(CompanyDto request, long userId, string loginId);
	Task<ResultDto> Delete(long id, long userId, string loginId);
}

using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Shared;

namespace Amax.InsurancePro.Domain.Interfaces;

public interface ICompanyRepository
{
	Task<CompanyInfo> Get(long id);
	Task<TableResponse<CompanyInfo>> GetAll(TableParameter request);
	Task<Result> Add(string userLoginId, CompanyInfo company);
	Task<Result> Update(string userLoginId, CompanyInfo company);
	Task<Result> Delete(long id, long deletedBy);
}
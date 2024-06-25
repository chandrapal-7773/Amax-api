using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Shared;

namespace Amax.InsurancePro.Domain.Interfaces;

public interface IAgencyRepository
{
	Task<AgencyInfo> Get(long id);
	Task<TableResponse<AgencyInfo>> GetAll(TableParameter request);
	Task<Result> Add(string userLoginId, AgencyInfo agency);
	Task<Result> Update(string userLoginId, AgencyInfo agency);
	Task<Result> Delete(long id, long deletedBy);
}


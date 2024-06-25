using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Shared;

namespace Amax.InsurancePro.Domain.Interfaces;

public interface IAgentRepository
{
    Task<AgentInfo> Get(long id);
    Task<TableResponse<AgentInfo>> GetAll(TableParameter request);
    Task<AgentInfo> GetByUserId(string userId);
    Task<Result> Add(string userLoginId, AgentInfo agent);
    Task<Result> Update(string userLoginId, AgentInfo agent);
    Task<Result> Delete(long id, long deletedBy);
}
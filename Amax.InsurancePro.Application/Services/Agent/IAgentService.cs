using Amax.InsurancePro.Application.Dtos;

namespace Amax.InsurancePro.Application.Services;
public interface IAgentService
{
    Task<AgentDto> Get(long id);
    Task<AgentsDto> GetAll(TableParameterDto request);
    Task<AgentDto> GetByUserId(string userId);
    Task<ResultDto> Add(AgentDto request, long userId, string loginId);
    Task<ResultDto> Update(AgentDto request, long userId, string loginId);
    Task<ResultDto> Delete(long id, long userId, string loginId);
}

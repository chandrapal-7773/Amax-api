
namespace Amax.InsurancePro.Application.Dtos;

public class AgentsDto: BaseTableResponsDto
{
	public List<AgentDto> Data { get; set; } = new List<AgentDto>();
}


namespace Amax.InsurancePro.Application.Dtos;

public class AgenciesDto: BaseTableResponsDto
{
	public List<AgencyDto> Data { get; set; } = new List<AgencyDto>();
}

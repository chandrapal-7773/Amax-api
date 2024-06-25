using Amax.InsurancePro.Application.Dtos;

public class CompaniesDto : BaseTableResponsDto
{
	public List<CompanyDto> Data { get; set; } = new List<CompanyDto>();
}

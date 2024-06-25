namespace Amax.InsurancePro.Application.Dtos;

public class TableParameterDto
{
	public TableParameterDto()
	{
		Start = 1;
		Length = int.MaxValue;
		IsActiveOnly = true;
	}

	public bool IsActiveOnly { get; set; }
	public int Start { get; set; }
	public int Length { get; set;}

	//Todo orderby, sorting, filter, search, global search?
}


namespace Amax.InsurancePro.Domain.Entities.Custom;

public class TableParameter
{
	public TableParameter()
	{
		Start = 1;
		Length = int.MaxValue;
		IsActiveOnly = true;
	}

	//Todo
	public int UserId;
	public string UserLoginId;

	public bool IsActiveOnly { get; set; }
	public int Start { get; set; }
	public int Length { get; set;}
}


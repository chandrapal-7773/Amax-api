namespace Amax.InsurancePro.Domain.Entities
{
	public class BaseRequest
	{
		public long Id { get; set; }
		public long UserId { get; set; }
		public long RoleId { get; set; }
		public string UserLoginId { get; set; }
		public int PageSize { get; set; }
		public int PageNumber { get; set; }
		public bool? Active { get; set; }

	}
}

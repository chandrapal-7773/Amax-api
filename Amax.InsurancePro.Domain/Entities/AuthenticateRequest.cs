namespace Amax.InsurancePro.Domain.Entities
{
	public class AuthenticateRequest
	{
		public string? Username { get; set; }
		public string? Password { get; set; }
		public string? NewPassword { get; set; }
	}
}

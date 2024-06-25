namespace Amax.InsurancePro.Domain.Exceptions.Business
{
	public class ResourceNotFoundException: BusinessException
	{
		private const int DefaultCode = 404;
		private new const string DefaultMessage = "Resource NotFound";
		public ResourceNotFoundException():base(DefaultCode, DefaultMessage)
		{
		}

		public ResourceNotFoundException(string message) : base(DefaultCode, message)
		{
		}

		public ResourceNotFoundException(string message, Exception innerException) : base(DefaultCode, message, innerException)
		{
		}
	}
}

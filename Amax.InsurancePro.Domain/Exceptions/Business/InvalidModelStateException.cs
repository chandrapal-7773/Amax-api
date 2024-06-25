namespace Amax.InsurancePro.Domain.Exceptions.Business
{
	public class InvalidModelStateException : BusinessException
	{
		private const int DefaultCode = 400;
		private new const string DefaultMessage = "Request data is not in correct format!";
		public InvalidModelStateException():base(DefaultCode, DefaultMessage)
		{
		}

		public InvalidModelStateException(string message) : base(DefaultCode, message)
		{
		}

		public InvalidModelStateException(string message, Exception innerException) : base(DefaultCode, message, innerException)
		{
		}
	}
}

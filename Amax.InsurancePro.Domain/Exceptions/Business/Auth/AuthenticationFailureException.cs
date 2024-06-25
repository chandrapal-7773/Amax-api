namespace Amax.InsurancePro.Domain.Exceptions.Business.Auth
{
	public class AuthenticationFailureException : BusinessException
    {
        private const int DefaultCode = 401;
        private new const string DefaultMessage = "Authentication Failure, Check Username and Password!";
        public AuthenticationFailureException() : base(DefaultCode, DefaultMessage)
        {
        }

        public AuthenticationFailureException(string message) : base(DefaultCode, message)
        {
        }

        public AuthenticationFailureException(string message, Exception innerException) : base(DefaultCode, message, innerException)
        {
        }
    }
}

namespace Amax.InsurancePro.Domain.Exceptions.Business
{
	public class BusinessException : Exception
    {
        public int Code = 400;
        public string DefaultMessage = "Business Exception";


		public BusinessException()
        {
        }

        public BusinessException(string message): base(message)
        {
        }
		public BusinessException(string message, Exception innerException) : base(message, innerException)
		{
		}
		public BusinessException(int code, string message) : base(message)
        {
            Code = code;
        }

        public BusinessException(int code, string message, Exception innerException) : base(message, innerException)
        {
			Code = code;
		}
    }
}

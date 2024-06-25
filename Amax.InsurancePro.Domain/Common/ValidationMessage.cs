namespace Amax.InsurancePro.Domain.Common;
public class ValidationMessage
{
    public const string ValidationFailedMessage = "Validation Failed";
    public struct HttpStatusMessage
    {
        public const string SomethingWentWrong = "Something went wrong with your request. Please reconsider it.";
    }

    public struct Login
    {
        public const string EmptyUser = "You must first enter a User ID to login";
        public const string EmptyPassword = "You must first enter a Password to login";
    }
    public struct Password
    {
        public const string EmptyUser = "You must provide a User ID to reset password";
        public const string EmptyPasswordOld = "You must first enter a Old Password";
        public const string EmptyPasswordNew = "Password must be at least 8 characters long with combination of letters (lower and upper case), numbers and at least one special character";
        public const string MinimumLength = "Password must contain at least 8 characters";
        public const string Uppercase = "Password must contain at least one uppercase letter (ex: A,B,C.. etc)";
        public const string Lowercase = "Password must contain at least one lowercase letter (ex: a,b,c.. etc)";
        public const string Digit = "Password must contain at least 1 number digit (ex: 0,1,3.. etc)";
        public const string Special = "Password must contain at least 1 special character";

        public const string Success = "Your password is reset successfully";
        public const string Fail = "Your old password may be wrong. Please recheck your old password";
        public const string Same = "The new password you provided cannot be same as the old password";
    }

    public struct Agent
    {
        public const string NotFound = "Agent was not found";
        public const string InvalidUserId = "Please choose a valid user id";
        public const string AlreadyExistsUserId = "This user id is already in use. Please choose a different user id";
        public const string NotSaved = "The Agent could be saved. Please check all fields for required information";
    }
}
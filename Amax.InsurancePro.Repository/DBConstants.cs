namespace Amax.InsurancePro.Repository;

public class DBConstants
{
    #region Logging
    public struct Logging
    {
        public const string ErrorLogAdd = "[web].Log_Error_Add";
        public const string ErrorSQLLogAdd = "[web].Log_SQLError_Add";
    }
    #endregion

    #region Authentication
    public struct Authentication
    {
        public const string ValidateUser = "[dbo].Auth_ValidateUser";
        public const string GetUserInfo = "[dbo].Auth_GetUserInfo";
    }

    #endregion
}

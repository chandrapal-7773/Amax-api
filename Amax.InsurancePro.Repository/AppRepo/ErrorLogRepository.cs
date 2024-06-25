namespace Amax.InsurancePro.Repository;

//[ScopedService]
//public class ErrorLogRepository : Repository, IErrorLogRepository
//{
//    private readonly AppSettings _appSettings;
//    public ErrorLogRepository(IOptionsSnapshot<AppSettings> appSettings) : base(appSettings) { }

//    public async Task<int> Log(ErrorLogRequest request)
//    {
//        DynamicParameters parameters = new DynamicParameters();
//        parameters.Add("@ErrorMessage", request.ErrorLog.ErrorMessage, DbType.String, ParameterDirection.Input);
//        parameters.Add("@StackTrace", request.ErrorLog.StackTrace, DbType.String, ParameterDirection.Input);
//        parameters.Add("@ControllerName", request.ErrorLog.ControllerName, DbType.String, ParameterDirection.Input);
//        parameters.Add("@ActionName", request.ErrorLog.ActionName, DbType.String, ParameterDirection.Input);

//        int recordAffected = await AddAsync(DBConstants.Logging.ErrorLogAdd, parameters,
//                            commandTimeout: 0,
//                            commandType: CommandType.StoredProcedure,
//                            databaseName: Common.Enums.E_DatabaseName.DevDB);
//        return recordAffected;
//    }
//}

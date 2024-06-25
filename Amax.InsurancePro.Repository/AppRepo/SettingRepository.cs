using Amax.InsurancePro.Domain.Common;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Interfaces;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace Amax.InsurancePro.Repository;

public class SettingRepository : Repository, ISettingRepository
{
	public SettingRepository(IOptionsMonitor<AppSettings> appSettings)
		: base(appSettings) { }

	public async Task<DateTime> GetServerTime()
    {
        DynamicParameters parameters = new();

        var reader = await ExecuteScalarAsync("SELECT GETDATE()", parameters,
                    commandTimeout: 0,
                    commandType: CommandType.Text,
                    databaseName: Enums.DatabaseName.IPAdminDB);

        var dateTime = reader.Read<DateTime>().FirstOrDefault();
        return dateTime;
    }

    public async Task<UserLoginInfo> GetUserLoginInfo(AuthenticateRequest request)
    {
        DynamicParameters parameters = new();
        parameters.Add("@UserName", request.Username, DbType.String, ParameterDirection.Input);

        var reader = await ExecuteScalarAsync(DBConstants.Authentication.GetUserInfo, parameters,
                    commandTimeout: 0,
                    commandType: CommandType.StoredProcedure,
                    databaseName: Enums.DatabaseName.AmaxDB);

        UserLoginInfo user = reader.Read<UserLoginInfo>().FirstOrDefault();
        return user;
    }

    public async Task<bool> BlockUser(AuthenticateRequest request)
    {
        DynamicParameters parameters = new();
        parameters.Add("@uid", request.Username, DbType.String, ParameterDirection.Input);

        var rowsAffected = await UpdateAsync("UPDATE agentInfo SET bLocked = 1, DateModified = GETDATE() WHERE UserID = @uid", parameters,
                    commandTimeout: 0,
                    commandType: CommandType.Text,
                    databaseName: Enums.DatabaseName.AmaxDB);
        return rowsAffected > 0;
    }
}

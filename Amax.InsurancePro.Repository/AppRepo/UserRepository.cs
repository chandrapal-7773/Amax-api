
using Amax.InsurancePro.Domain.Common;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Interfaces;
using Dapper;
using Microsoft.Extensions.Options;
using System.Data;

namespace Amax.InsurancePro.Repository;

public class UserRepository : Repository, IUserRepository
{
    public UserRepository(IOptionsMonitor<AppSettings> appSettings)
		: base(appSettings) { }

	public async Task<string> Authenticate(AuthenticateRequest request)
    {
        DynamicParameters parameters = new();
        parameters.Add("@UserName", request.Username, DbType.String, ParameterDirection.Input);
        parameters.Add("@Password", request.Password, DbType.String, ParameterDirection.Input);

        var reader = await ExecuteScalarAsync(DBConstants.Authentication.ValidateUser, parameters,
                    commandTimeout: 0,
                    commandType: CommandType.StoredProcedure,
                    databaseName: Enums.DatabaseName.IPAdminDB);

        var connectionString = reader.Read<ConnectionString>().FirstOrDefault();
        if (connectionString != null)
        {
            return new AmaxDB(connectionString).ToString();
        }
        return string.Empty;
    }

    public async Task<UserLoginInfo> GetUserLoginInfo(AuthenticateRequest request)
    {
        DynamicParameters parameters = new();
        parameters.Add("@UserName", request.Username, DbType.String, ParameterDirection.Input);
        var sql = $"SELECT agentID AS UserId " +
                $"	, userID AS UserLoginId " +
                $"	, agentName AS UserName " +
                $"	, email AS UserEmail " +
                $"	, CAST(passwordUpdatedDate AS DATE) AS passwordUpdatedDate " +
                $"	, CAST(bLocked AS BIT) AS Disabled " +
                $"	, CAST(agentActive AS BIT) AS Active " +
                $"	, CAST(adminAccess AS BIT) AS IsAdmin " +
                $" FROM dbo.agentInfo" +
                $" WHERE userID = @UserName" +
                $"	AND IIF(DeletedBy > 0, 1, 0) = 0";

        var reader = await ExecuteScalarAsync(sql, parameters,
                    commandTimeout: 0,
                    commandType: CommandType.Text,
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

    public async Task<bool> ResetPassword(AuthenticateRequest request)
    {
        DynamicParameters parameters = new();
        parameters.Add("@uid", request.Username, DbType.String, ParameterDirection.Input);
        parameters.Add("@opswd", request.Password, DbType.String, ParameterDirection.Input);
        parameters.Add("@npswd", request.NewPassword, DbType.String, ParameterDirection.Input);

        var rowsAffected = await UpdateAsync("UPDATE agentInfo SET Password = @npswd WHERE UserID = @uid AND Password = @opswd", parameters,
                    commandTimeout: 0,
                    commandType: CommandType.Text,
                    databaseName: Enums.DatabaseName.AmaxDB);
        return rowsAffected > 0;
    }
}

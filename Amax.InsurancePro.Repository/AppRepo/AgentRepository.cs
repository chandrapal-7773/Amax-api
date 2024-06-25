using Amax.InsurancePro.Domain.Common;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Interfaces;
using Amax.InsurancePro.Domain.Shared;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Options;
using System.Data;


namespace Amax.InsurancePro.Repository;

public class AgentRepository : Repository, IAgentRepository
{
	public AgentRepository(IOptionsMonitor<AppSettings> appSettings)
        : base(appSettings) { }

	public async Task<AgentInfo> Get(long id)
	{
		AgentInfo agent = null;
		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			agent = await connection.GetAsync<AgentInfo>(id, commandTimeout: 0);

			if(agent != null)
			{

				var agencies = await GetAsync<AgencyInfo>(
					$" SELECT agencyInfo.* FROM AgentLocations left join agencyInfo on locationId = agencyId WHERE" +
					$" agentId = " + agent.AgentId,
					null,
					commandTimeout: 0,
					commandType: CommandType.Text,
					databaseName: Enums.DatabaseName.AmaxDB);

				if(agencies != null)
					agent.Agencies = agencies.ToList();

			}


		}
		return agent;
	}

	public async Task<AgentInfo> GetByUserId(string userId)
	{
		DynamicParameters parameters = new();
		parameters.Add("@UserId", userId, DbType.String, ParameterDirection.Input);

		var reader = await ExecuteScalarAsync("SELECT * FROM agentInfo WHERE UserId = @UserId AND agentActive = 1 ", parameters,
					commandTimeout: 0,
					commandType: CommandType.Text,
					databaseName: Enums.DatabaseName.AmaxDB);

		var agent = reader.Read<AgentInfo>().FirstOrDefault();
		return agent;
	}

	public async Task<TableResponse<AgentInfo>> GetAll(TableParameter request)
	{
		int count = 0;
		IEnumerable<AgentInfo> agents = null;

		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			var qry = $" SELECT * FROM agentInfo WHERE ";
				if(request.IsActiveOnly)
					qry += $" agentActive = 1";
				else
					qry += $" agentActive <= 0";
			qry += $" ORDER BY AgentName" +
				$" OFFSET @Start ROWS FETCH NEXT @Length ROWS ONLY";

			var qryParams = new { Start = request.Start, Length = request.Length };

			agents = await connection.QueryAsync<AgentInfo>(qry, qryParams);

			count = agents.Count();

		}

		return new TableResponse<AgentInfo>(agents.ToList(), count,count, request.Start,request.Length);

	}

	public async Task<Result> Add(string userLoginId, AgentInfo agent)
	{

		IDbConnection connectionAmaxDB = null;
		IDbConnection connectionIPAdmin = null;
		IDbTransaction transactionAmaxDB = null;
		IDbTransaction transactionIPAdmin = null;

		Result result = new Result();

		try
		{
			connectionAmaxDB = GetConnection(Enums.DatabaseName.AmaxDB);
			connectionIPAdmin = GetConnection(Enums.DatabaseName.IPAdminDB);
			connectionAmaxDB.Open();
			connectionIPAdmin.Open();
			transactionAmaxDB = connectionAmaxDB.BeginTransaction();
			transactionIPAdmin = connectionIPAdmin.BeginTransaction();

			agent.DateDeleted = null;
			agent.AgentActive = 1;
			agent.DateCreated = DateTime.UtcNow; //TODO 
			agent.DateModified = DateTime.UtcNow;
			agent.SysUtcdateCreated = DateTime.UtcNow;
			agent.SysUtcdateModified = DateTime.UtcNow;
			agent.PasswordUpdatedDate = DateTime.UtcNow;
			agent.AaAgentId = "9999";//userLoginId; //TODO truncate issue, its expecting string but small number not username
			agent.EzlynxId = " ";//TODO varchar notnull
			agent.TurboRaterId = " ";//TODO varchar notnull

			result.Id = Convert.ToInt32(await connectionAmaxDB.InsertAsync(agent, commandTimeout: 0, transaction: transactionAmaxDB));

			if (agent.SelectedLocations != null && agent.SelectedLocations.Count > 0)
			{
				List<AgentLocations> agentLocations = new List<AgentLocations>();

				for (int i = 0; i < agent.SelectedLocations.Count; i++)
				{
					agentLocations.Add(new AgentLocations
					{
						AgentId = (int)result.Id,
						LocationId = agent.SelectedLocations[i],
						Deleted = false,
						defaultLocation = false
					}); ;
				}

				var rows = connectionAmaxDB.Insert(agentLocations, transaction: transactionAmaxDB);


			}

			var agentDb = connectionIPAdmin.QueryFirstOrDefault<Guid>("SELECT AgentDB FROM AgentLogin WHERE AgentId = @Id", new { Id = userLoginId }, transactionIPAdmin);

			var agentLogin = new AgentLogin
			{
				AgentDB = agentDb,
				AgentId = agent.UserId,
				AgentPassword = agent.Password,
				IsActive = true,
				LoginAttempts = 0,
			};

			var resIpAdmin = await connectionIPAdmin.InsertAsync(agentLogin, commandTimeout: 0, transaction: transactionIPAdmin);

			transactionAmaxDB.Commit();
			transactionIPAdmin.Commit();
		}
		catch (Exception e)
		{
			transactionAmaxDB?.Rollback();
			transactionIPAdmin?.Rollback();
			throw;//todo custom exceptions
		}
		finally
		{
			transactionAmaxDB.Dispose();
			transactionIPAdmin.Dispose();
			connectionIPAdmin.Dispose();
			connectionAmaxDB.Dispose();

		}
			
		return result;

	}

	public async Task<Result> Update(string UserLoginId, AgentInfo agent)
	{

		Result result = new Result();

		IDbConnection connectionAmaxDB = null;
		IDbConnection connectionIPAdmin = null;
		IDbTransaction transactionAmaxDB = null;
		IDbTransaction transactionIPAdmin = null;

		try
		{
			connectionAmaxDB = GetConnection(Enums.DatabaseName.AmaxDB);
			connectionIPAdmin = GetConnection(Enums.DatabaseName.IPAdminDB);
			connectionAmaxDB.Open();
			connectionIPAdmin.Open();
			transactionAmaxDB = connectionAmaxDB.BeginTransaction();
			transactionIPAdmin = connectionIPAdmin.BeginTransaction();


			var oldAgentInfo = await connectionAmaxDB.GetAsync<AgentInfo>(agent.AgentId, transaction: transactionAmaxDB);
			var oldAgentLogin = connectionIPAdmin.QueryFirstOrDefault<AgentLogin>("SELECT * FROM AgentLogin WHERE AgentId = @Id", new { Id = agent.UserId }, transactionIPAdmin);

			agent.DateModified = DateTime.Now;
			agent.SysUtcdateModified = DateTime.Now;
			agent.AaAgentId = "9999";//userLoginId; //TODO truncate issue, its expecting string but small number not username

			var hasPasswordUpdated = agent.Password != oldAgentLogin.AgentPassword ;

			agent.DateDeleted = null;
			agent.AgentActive = oldAgentInfo.AgentActive;
			agent.DateCreated = oldAgentInfo.DateCreated;
			agent.DateModified = DateTime.UtcNow;
			agent.SysUtcdateCreated = oldAgentInfo.SysUtcdateCreated;
			agent.SysUtcdateModified = DateTime.UtcNow;
			agent.PasswordUpdatedDate = hasPasswordUpdated ? DateTime.UtcNow : oldAgentInfo.PasswordUpdatedDate;
			agent.AaAgentId = "9999";//userLoginId; //TODO truncate issue, its expecting string but small number not username
			agent.EzlynxId = " ";//TODO varchar notnull
			agent.TurboRaterId = " ";//TODO varchar notnull


			var IsSuccess = await connectionAmaxDB.UpdateAsync(agent, commandTimeout: 0, transaction: transactionAmaxDB);

			if (IsSuccess)
				result.Id = agent.AgentId;

			var oldAgentLocations = await connectionAmaxDB.QueryAsync<AgentLocations>($" SELECT * FROM AgentLocations WHERE ISNULL(AgentLocations.Deleted, 0) = 0 AND agentId = @Id", new {Id = agent.AgentId }, transaction: transactionAmaxDB);

			var newSelectedIds = agent.SelectedLocations;

			var toDel = oldAgentLocations.Where(l => !newSelectedIds.Contains(l.LocationId)).ToList();

			var toAddIds = newSelectedIds.Where(id => !oldAgentLocations.Any(l => l.LocationId == id));

			var willRemain = oldAgentLocations.Where(l => newSelectedIds.Contains(l.LocationId)).ToList();

			var resDel = await connectionAmaxDB.ExecuteAsync($"UPDATE AgentLocations SET Deleted = 1 WHERE Id IN @Ids",
					new { Ids = toDel.Select(td => td.id).ToList() }, transactionAmaxDB);

			var toAdd = toAddIds.Select(id => new AgentLocations
			{
				id = 0,
				AgentId = agent.AgentId,
				LocationId = id,
				Deleted = false,
				defaultLocation = false

			});

			var resAdd = connectionAmaxDB.Insert(toAdd, transaction: transactionAmaxDB);


			if(agent.UserId != oldAgentLogin.AgentId || agent.Password != oldAgentLogin.AgentPassword)
			{
				var resAUpdate = await connectionIPAdmin.ExecuteAsync($"UPDATE AgentLogin SET AgentId = @NewAgentId AND AgentPassword = @AgentPassword WHERE AgentId = @OldAgentId",
						new { OldAgentId = oldAgentInfo.AgentId, NewAgentId = agent.UserId, AgentPassword = agent.Password }, transactionIPAdmin);
			}


			transactionAmaxDB.Commit();
			transactionIPAdmin.Commit();
		}
		catch (Exception e)
		{
			transactionAmaxDB?.Rollback();
			transactionIPAdmin?.Rollback();
			throw;//todo custom exceptions
		}
		finally
		{
			transactionAmaxDB?.Dispose();
			transactionIPAdmin?.Dispose();
			connectionIPAdmin?.Dispose();
			connectionAmaxDB?.Dispose();

		}
			
		return result;

	}

	public async Task<Result> Delete(long agentId, long userId)//user LoginId
	{
		Result result = new Result();

		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			var agent = await connection.GetAsync<AgentInfo>(agentId, commandTimeout: 0);
			if (agent != null)
			{
				agent.AgentActive = 0;
				agent.DateDeleted = DateTime.UtcNow;
				agent.DeletedBy = Convert.ToInt32(userId);
				agent.DateModified = DateTime.UtcNow;
				agent.SysUtcdateModified = DateTime.UtcNow;
				var IsSuccess = await connection.UpdateAsync(agent, commandTimeout: 0);
				if(IsSuccess)
					result.Id = agentId;
			}
		}
		return result;
	}

}

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

public class AgencyRepository : Repository, IAgencyRepository
{
	public AgencyRepository(IOptionsMonitor<AppSettings> appSettings)
        : base(appSettings) { }


	public async Task<AgencyInfo> Get(long id)
	{
		AgencyInfo agency = null;
		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			agency = await connection.GetAsync<AgencyInfo>(id, commandTimeout: 0);
		}
		return agency;
	}

	public async Task<TableResponse<AgencyInfo>> GetAll(TableParameter request)
	{
		int count = 0;
		IEnumerable<AgencyInfo> companies = new List<AgencyInfo>();

		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			var qry = $" SELECT * FROM agencyInfo WHERE " +
				$" Deleted = @Deleted" +
				$" ORDER BY agencyId" +
				$" OFFSET @Start ROWS FETCH NEXT @Length ROWS ONLY";

			var qryParams = new { Deleted = !request.IsActiveOnly, Start = request.Start, Length = request.Length };

			companies = await connection.QueryAsync<AgencyInfo>(qry, qryParams);

			count = companies.Count();

		}

		return new TableResponse<AgencyInfo>(companies.ToList(), count, count, request.Start, request.Length);
	}

	public async Task<Result> Add(string userLoginId, AgencyInfo agency)
	{
		Result result = new Result();
		//using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		//{
		//	agent.DateDeleted = null;
		//	agent.AgentActive = 1;
		//	agent.DateCreated = DateTime.Now; //TODO 
		//	agent.DateModified = DateTime.Now;
		//	agent.SysUtcdateCreated = DateTime.UtcNow;
		//	agent.SysUtcdateModified = DateTime.UtcNow;
		//	agent.PasswordUpdatedDate = DateTime.Now;
		//	agent.AaAgentId = "9999";//userLoginId; //TODO truncate issue, its expecting string but small number not username
		//	agent.EzlynxId = " ";//TODO varchar notnull
		//	agent.TurboRaterId = " ";//TODO varchar notnull


		//	result.Id = Convert.ToInt32(await connection.InsertAsync(agent, commandTimeout: 0));

		//}
		return result;
	}

	public async Task<Result> Update(string UserLoginId, AgencyInfo agency)
	{
		Result result = new Result();
		//using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		//{
		//	agent.DateModified = DateTime.Now;
		//	agent.SysUtcdateModified = DateTime.Now;
		//	agent.AaAgentId = "9999";//userLoginId; //TODO truncate issue, its expecting string but small number not username
		//	var IsSuccess = await connection.UpdateAsync(agent, commandTimeout: 0);
		//	if (IsSuccess)
		//	{
		//		result.Id = agent.AgentId;
		//	}
		//}
		return result;
	}

	public async Task<Result> Delete(long agencyId, long userId)//user LoginId
	{
		Result result = new Result();
		//using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		//{
		//	var agent = await connection.GetAsync<AgentInfo>(agentId, commandTimeout: 0);
		//	if (agent != null)
		//	{
		//		agent.DateDeleted = DateTime.Now;
		//		agent.DeletedBy = Convert.ToInt32(userId);
		//		agent.DateModified = DateTime.Now;
		//		agent.SysUtcdateModified = DateTime.Now;
		//		var IsSuccess = await connection.UpdateAsync(agent, commandTimeout: 0);
		//		if(IsSuccess)
		//			result.Id = agentId;
		//	}
		//}
		return result;
	}

}

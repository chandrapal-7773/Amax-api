using Amax.InsurancePro.Domain.Common;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Interfaces;
using Amax.InsurancePro.Domain.Shared;
using Dapper;
using Dapper.Contrib.Extensions;
using Microsoft.Extensions.Options;
using System.Data;
using System.Globalization;

namespace Amax.InsurancePro.Repository;

public class CompanyRepository : Repository, ICompanyRepository
{
	public CompanyRepository(IOptionsMonitor<AppSettings> appSettings)
	: base(appSettings) { }

	public async Task<CompanyInfo> Get(long id)
	{
		CompanyInfo company = null;
		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			company = await connection.GetAsync<CompanyInfo>(id, commandTimeout: 0);
		}
		return company;
	}

	public async Task<TableResponse<CompanyInfo>> GetAll(TableParameter request)
	{
		int count = 0;
		IEnumerable<CompanyInfo> companies = new List<CompanyInfo>();

		using (var connection = GetConnection(Enums.DatabaseName.AmaxDB))
		{
			var qry = $" SELECT * FROM companyInfo WHERE " +
				$" Deleted = @Deleted" +
				$" ORDER BY coName" +
				$" OFFSET @Start ROWS FETCH NEXT @Length ROWS ONLY";

			var qryParams = new { Deleted = !request.IsActiveOnly, Start = request.Start, Length = request.Length };

			companies = await connection.QueryAsync<CompanyInfo>(qry, qryParams);

			count = companies.Count();

		}

		return new TableResponse<CompanyInfo>(companies.ToList(), count, count, request.Start, request.Length);
	}

	public async Task<Result> Add(string userLoginId, CompanyInfo company)
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

	public async Task<Result> Update(string UserLoginId, CompanyInfo company)
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

	public async Task<Result> Delete(long companyId, long userId)//user LoginId
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

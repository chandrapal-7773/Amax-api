
using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Amax.InsurancePro.API.Controllers;

public class AgentController : BaseController
{
	private readonly IAgentService _agentService;
	private readonly ISettingService _settingService;
	private readonly IMapper _mapper;


	public AgentController(IAgentService agentService, ISettingService settingService, IMapper mapper)
	{
		_agentService = agentService;
		_settingService = settingService;
		_mapper = mapper;
	}

	[HttpGet]
	[ProducesResponseType(200, Type = typeof(AgentDto))]
	public async Task<IActionResult> Get(int id)
	{
		var response = await _agentService.Get(id);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpPost]
	[ProducesResponseType(200, Type = typeof(AgentsDto))]
	public async Task<IActionResult> GetAll(TableParameterDto tableParameterDto)
	{
		var response = await _agentService.GetAll(tableParameterDto);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpPost]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Add(AgentDto request)
	{
		var response = await _agentService.Add(request, LoggedInUser.UserId, LoggedInUser.UserLoginId);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpPut("{id}")]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Update(int id, AgentDto request)
	{
		//TODO validations
		request.AgentId = id;
		var response = await _agentService.Update(request, LoggedInUser.UserId, LoggedInUser.UserLoginId);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpDelete("{id}")]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Delete(int id)
	{
		var response = await _agentService.Delete(id, LoggedInUser.UserId, LoggedInUser.UserLoginId);
		return Ok(response);
	}

}
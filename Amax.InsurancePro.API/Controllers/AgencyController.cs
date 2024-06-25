
using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Amax.InsurancePro.API.Controllers;

public class AgencyController : BaseController
{
	private readonly IAgencyService _agencyService;
	private readonly ISettingService _settingService;
	private readonly IMapper _mapper;


	public AgencyController(IAgencyService agencyService, ISettingService settingService, IMapper mapper)
	{
		_agencyService = agencyService;
		_settingService = settingService;
		_mapper = mapper;
	}


	[HttpPost]
	[ProducesResponseType(200, Type = typeof(AgenciesDto))]
	public async Task<IActionResult> GetAll(TableParameterDto tableParameterDto)
	{
		var response = await _agencyService.GetAll(tableParameterDto);

		return Ok(response);
	}

	[HttpGet]
	[ProducesResponseType(200, Type = typeof(AgencyDto))]
	public async Task<IActionResult> Get(int id)
	{
		var response = await _agencyService.Get(id);

		return Ok(response);
	}


	[HttpPost]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Add(AgencyDto request)
	{
		var response = await _agencyService.Add(request, LoggedInUser.UserId, LoggedInUser.UserLoginId);

		return Ok(response);
	}


	[HttpPut("{id}")]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Update(int id, AgencyDto request)
	{
		//TODO validations
		request.AgencyId = id;
		var response = await _agencyService.Update(request, LoggedInUser.UserId, LoggedInUser.UserLoginId);

		return Ok(response);
	}

	
	[HttpDelete("{id}")]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Delete(int id)
	{
		var response = await _agencyService.Delete(id, LoggedInUser.UserId, LoggedInUser.UserLoginId);
		return Ok(response);
	}
}
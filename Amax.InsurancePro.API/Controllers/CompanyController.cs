
using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Amax.InsurancePro.API.Controllers;

public class CompanyController : BaseController
{
	private readonly ICompanyService _companyService;
	private readonly ISettingService _settingService;
	private readonly IMapper _mapper;


	public CompanyController(ICompanyService companyService, ISettingService settingService, IMapper mapper)
	{
		_companyService = companyService;
		_settingService = settingService;
		_mapper = mapper;
	}

	[HttpGet]
	[ProducesResponseType(200, Type = typeof(CompanyDto))]
	public async Task<IActionResult> Get(int id)
	{
		var response = await _companyService.Get(id);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpPost]
	[ProducesResponseType(200, Type = typeof(CompaniesDto))]
	public async Task<IActionResult> GetAll(TableParameterDto tableParameterDto)
	{
		var response = await _companyService.GetAll(tableParameterDto);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpPost]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Add(CompanyDto request)
	{
		var response = await _companyService.Add(request, LoggedInUser.UserId, LoggedInUser.UserLoginId);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpPut("{id}")]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Update(int id, CompanyDto request)
	{
		//TODO validations
		request.CompanyID = id;
		var response = await _companyService.Update(request, LoggedInUser.UserId, LoggedInUser.UserLoginId);

		return Ok(response);
	}

	[Authorize("AdminOnly")]
	[HttpDelete("{id}")]
	[ProducesResponseType(200, Type = typeof(ResultDto))]
	public async Task<IActionResult> Delete(int id)
	{
		var response = await _companyService.Delete(id, LoggedInUser.UserId, LoggedInUser.UserLoginId);
		return Ok(response);
	}

}
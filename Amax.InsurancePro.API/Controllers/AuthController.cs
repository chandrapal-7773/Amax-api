
using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Amax.InsurancePro.API.Controllers;

public class AuthController : BaseController
{
    private readonly IAuthService _authService;
	private readonly ISettingService _settingService;

	public AuthController(IAuthService authService, ISettingService settingService)
    {
		_authService = authService;
		_settingService = settingService;
    }

    [AllowAnonymous]
    [ProducesResponseType(200, Type = typeof(AuthenticateResponseDto))]
    [HttpPost]
    public async Task<IActionResult> Authenticate(AuthenticateRequestDto request)
    {
		var result = await _authService.Login(request);

		return Ok(result);
	}

    [HttpPost]
	[ProducesResponseType(200)]
	public async Task<IActionResult> ResetPassword(AuthenticateRequestDto request)
    {
		var result = await _authService.ResetPassword(request);

		return Ok(result);
	}

}
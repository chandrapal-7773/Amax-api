using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;


namespace Amax.InsurancePro.API.Controllers;

[ApiController]
[Authorize]
[Route("api/[controller]/[action]")]
public class BaseController : ControllerBase
{
	private readonly AppSettings _appConfigurations;

	public BaseController()
	{

	}

	public BaseController(IOptions<AppSettings> appSettings)
    {
		_appConfigurations = appSettings.Value;
    }

	protected AppSettings AppSettings
	{
		get
		{
			return _appConfigurations;
		}
	}

	protected UserLoginInfo LoggedInUser
	{
		get
		{
			UserLoginInfo _user = null;
			if (HttpContext != null)
			{
				var user = (UserLoginInfo)HttpContext.Items["User"];
				if (user != null)
				{
					_user = user;
				}
			}
			return _user;
		}
	}

}
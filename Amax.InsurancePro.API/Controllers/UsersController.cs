
using Amax.InsurancePro.Application.Services;

namespace Amax.InsurancePro.API.Controllers;

public class UsersController : BaseController
{
    private readonly IUserService _userService;
	private readonly ISettingService _settingService;

	public UsersController(IUserService userService, ISettingService settingService)
    {
        _userService = userService;
		_settingService = settingService;
    }



}
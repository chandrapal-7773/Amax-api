
using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services.Utilities;
using Amax.InsurancePro.Domain.Common;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Exceptions.Business.Auth;
using Amax.InsurancePro.Domain.Interfaces;
using AutoMapper;
using FluentValidation;

namespace Amax.InsurancePro.Application.Services;

public class AuthService : IAuthService
{
    private readonly IAgentRepository _arepo;
    private readonly IUserRepository _repo;
    private readonly IJwtUtils _jwtUtils;
	private readonly ISettingService _settingService;
	private readonly IMapper _mapper;
	private readonly IValidator<AuthenticateRequestDto> _validator;

	public AuthService(
        IUserRepository repo,
		ISettingService settingService,
		IAgentRepository aRepo,
        IJwtUtils jwtUtils,
		IValidator<AuthenticateRequestDto> validator,
		IMapper mapper)
    {
        _repo = repo;
        _arepo = aRepo;
        _jwtUtils = jwtUtils;
		_settingService = settingService;
		_mapper = mapper;
		_validator = validator;
    }

	public async Task<AuthenticateResponseDto> Login(AuthenticateRequestDto requestDto)
	{
		await _validator.ValidateAndThrowAsync(requestDto);

		var authRequest = _mapper.Map<AuthenticateRequest>(requestDto);
		var connectionString = await _repo.Authenticate(authRequest);

		if (connectionString == null)
			throw new AuthenticationFailureException();

		//TODO decide how to handle connection strings. Inmemory/fetch/token identifier

		var loginInfo = await _repo.GetUserLoginInfo(authRequest);

		if (loginInfo == null)
			throw new AuthenticationFailureException();

		if (loginInfo.Disabled)
			throw new AuthenticationFailureException("Your account has been locked. Please contact your administrator");

		if ((Helper.LocalTime(await _settingService.GetServerTime()) - loginInfo.PasswordUpdatedDate).Days >= 90)
		{
			throw new AuthenticationFailureException("Your password has expired, please reset your password");
		}

		//TODO login attempts but not from request

		//TODO private for rights or rights management service?
		var agent = await _arepo.GetByUserId(loginInfo.UserLoginId);
		loginInfo.AgentRights = new AgentRights();
		loginInfo.AgentRights.SetRights(agent);
		var jwtToken = await _jwtUtils.GenerateJwtToken(loginInfo);

		return new AuthenticateResponseDto()
		{
			Token = jwtToken,
			LoginInfoDto = _mapper.Map<LoginInfoDto>(loginInfo)

		};

	}

	public async Task<bool> BlockUser(AuthenticateRequestDto request)
    {
		var authenticateRequest = _mapper.Map<AuthenticateRequest>(request);
		return await _repo.BlockUser(authenticateRequest);
    }

    public async Task<bool> ResetPassword(AuthenticateRequestDto request)
    {
		var authenticateRequest = _mapper.Map<AuthenticateRequest>(request);
		return await _repo.ResetPassword(authenticateRequest);
    }

}
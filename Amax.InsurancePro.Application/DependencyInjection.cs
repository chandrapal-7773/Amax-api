using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services;
using Amax.InsurancePro.Application.Services.Utilities;
using Amax.InsurancePro.Application.Validation;
using Amax.InsurancePro.Domain.Interfaces;
using Amax.InsurancePro.Repository;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Amax.InsurancePro.Application
{
	public static class DependencyInjection
	{
		public static void RegisterApplicationServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddMemoryCache(options => options.SizeLimit = 1024 * 1024 * 64);

			RegisterServices(services);
			RegisterRepositories(services);
			RegisterValidators(services);

		}

		private static void RegisterServices(IServiceCollection services)
		{
			services.AddScoped<IAuthService, AuthService>();
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IAgentService, AgentService>();
			services.AddScoped<IAgencyService, AgencyService>();
			services.AddScoped<ICompanyService, CompanyService>();
			services.AddScoped<ISettingService, SettingService>();
			services.AddScoped<IErrorLogService, ErrorLogService>();
			services.AddScoped<IJwtUtils, JwtUtils>();
		}

		private static void RegisterValidators(IServiceCollection services)
		{
			services.AddScoped<IValidator<AuthenticateRequestDto>, AuthenticationValidator>();
			services.AddScoped<IValidator<AgentDto>, AgentValidator>();
			services.AddScoped<IValidator<CompanyDto>, CompanyValidator>();
			services.AddScoped<IValidator<AgencyDto>, AgencyValidator>();
		}

		private static void RegisterRepositories(IServiceCollection services)
		{
			services.AddScoped<IUserRepository, UserRepository>();
			services.AddScoped<ISettingRepository, SettingRepository>();
			services.AddScoped<IAgentRepository, AgentRepository>();
			services.AddScoped<IAgencyRepository, AgencyRepository>();
			services.AddScoped<ICompanyRepository, CompanyRepository>();
		}
	}
}

using Amax.InsurancePro.Application.Dtos;
using FluentValidation.AspNetCore;

namespace Amax.Web.Helpers;

public static class ValidatorExtensions
{
	public static void RegisterFluentValidators(this IServiceCollection services)
	{


	}

	public static Dictionary<string, List<string>> ToResponseErrors(this FluentValidation.Results.ValidationResult result)
	{
		return (Dictionary<string, List<string>>)result.ToDictionary();
	}
}


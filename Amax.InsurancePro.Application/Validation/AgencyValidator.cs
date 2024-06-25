using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using FluentValidation;

namespace Amax.InsurancePro.Application.Validation;

public class AgencyValidator : AbstractValidator<AgencyDto>
{

	public AgencyValidator()
    {
        RuleFor<string>(x => x.AgencyName).NotNull().NotEmpty();
	}
}

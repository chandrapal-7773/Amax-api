using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using FluentValidation;

namespace Amax.InsurancePro.Application.Validation;

public class CompanyValidator : AbstractValidator<CompanyDto>
{

	public CompanyValidator()
    {
        RuleFor<string>(x => x.CoName).NotNull().NotEmpty();

	}
}

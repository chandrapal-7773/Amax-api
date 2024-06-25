using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using FluentValidation;

namespace Amax.InsurancePro.Application.Validation;

public class AuthenticationValidator : AbstractValidator<AuthenticateRequestDto>
{
    public AuthenticationValidator()
    {
        RuleFor<string>(x => x.Username).NotNull().NotEmpty().WithMessage(ValidationMessage.Login.EmptyUser);
        RuleFor<string>(x => x.Password).NotNull().NotEmpty().WithMessage(ValidationMessage.Login.EmptyPassword);
		
		RuleSet("Reset", () =>
		{
			RuleFor(authRequest => authRequest.NewPassword)
				.NotEmpty().WithMessage(ValidationMessage.Login.EmptyPassword)
				.Matches("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+{}\\[\\]:;<>,.?/~\\\\-]).*$").WithMessage(ValidationMessage.Login.EmptyPassword)
				.MinimumLength(8).WithMessage(ValidationMessage.Password.MinimumLength)
				.NotEqual(aReq => aReq.Password).WithMessage(ValidationMessage.Password.Same);


			RuleFor(authRequest => authRequest.NewPassword)
				.NotEmpty()
				.Equal(aReq => aReq.NewPassword).WithMessage(ValidationMessage.Password.Same);
		});

	}
}

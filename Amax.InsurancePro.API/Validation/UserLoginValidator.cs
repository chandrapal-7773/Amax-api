using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using FluentValidation;

namespace Amax.InsurancePro.Api.Validation;

public class AuthenticationValidator : AbstractValidator<AuthenticateRequestDto>
{
    public AuthenticationValidator()
    {
        RuleFor<string>(x => x.Username).NotNull().NotEmpty().WithMessage(ValidationMessage.Login.EmptyUser);
        RuleFor<string>(x => x.Password).NotNull().NotEmpty().WithMessage(ValidationMessage.Login.EmptyPassword);
    }
}

public class ResetPasswordValidator : AbstractValidator<AuthenticateRequestDto>
{
    public ResetPasswordValidator()
    {
        RuleFor<string>(x => x.Username).NotNull().NotEmpty().WithMessage(ValidationMessage.Password.EmptyUser);
        RuleFor<string>(x => x.Password).NotNull().NotEmpty().WithMessage(ValidationMessage.Password.EmptyPasswordOld);
        RuleFor<string>(x => x.NewPassword).NotNull().NotEmpty().WithMessage(ValidationMessage.Password.EmptyPasswordNew);
        RuleFor<string>(x => x.Password).NotEqual(x => x.NewPassword).WithMessage<AuthenticateRequestDto, string>(ValidationMessage.Password.Same);

        RuleFor<string>(x => x.NewPassword).MinimumLength(8).WithMessage<AuthenticateRequestDto, string>(ValidationMessage.Password.MinimumLength);
        RuleFor<string>(x => x.NewPassword).Matches("[A-Z]").WithMessage<AuthenticateRequestDto, string>(ValidationMessage.Password.Uppercase);
        RuleFor<string>(x => x.NewPassword).Matches("[a-z]").WithMessage<AuthenticateRequestDto, string>(ValidationMessage.Password.Lowercase);
        RuleFor<string>(x => x.NewPassword).Matches("[0-9]").WithMessage<AuthenticateRequestDto, string>(ValidationMessage.Password.Digit);
        RuleFor<string>(x => x.NewPassword).Matches("[^a-zA-Z0-9]").WithMessage<AuthenticateRequestDto, string>(ValidationMessage.Password.Special);
    }
}
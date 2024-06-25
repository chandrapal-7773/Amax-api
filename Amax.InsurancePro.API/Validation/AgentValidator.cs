using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using FluentValidation;

namespace Amax.InsurancePro.Api.Validation;

public class AgentValidator : AbstractValidator<AgentDto>
{
    public AgentValidator()
    {
        RuleFor<string>(x => x.UserId).NotNull().NotEmpty().WithMessage(ValidationMessage.Agent.InvalidUserId);
        RuleFor<string>(x=> x.Password).MinimumLength(8).WithMessage<AgentDto, string>(ValidationMessage.Password.MinimumLength);
        RuleFor<string>(x => x.Password).Matches("[A-Z]").WithMessage<AgentDto, string>(ValidationMessage.Password.Uppercase);
        RuleFor<string>(x => x.Password).Matches("[a-z]").WithMessage<AgentDto, string>(ValidationMessage.Password.Lowercase);
        RuleFor<string>(x => x.Password).Matches("[0-9]").WithMessage<AgentDto, string>(ValidationMessage.Password.Digit);
        RuleFor<string>(x => x.Password).Matches("[^a-zA-Z0-9]").WithMessage<AgentDto, string>(ValidationMessage.Password.Special);
    }
}
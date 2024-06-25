using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using FluentValidation;

namespace Amax.InsurancePro.Application.Validation;

public class AgentValidator : AbstractValidator<AgentDto>
{
	public struct PasswordMessages
	{
		public const string empty = "New Password must be at least 8 characters long with combination of letters (lower and upper case), numbers and at least one special character.";
		public const string lengthLow = "New Password must contain at least 8 characters.";
		public const string upperMissing = "New Password must contain at least one uppercase letter (ex: A,B,C.. etc).";
		public const string lowerMissing = "New Password must contain at least one lowercase letter (ex: a,b,c.. etc).";
		public const string numMissing = "New Password must contain at least 1 number digit (ex: 0,1,3.. etc).";
		public const string specialMissing = "New Password must contain at least 1 special character.";
		public const string newAndOldSame = "The new password you provided cannot be same as the old password";
		public const string newAndConfirmNotSame = "The new password and confirm password must be same";

	}

	public AgentValidator()
    {
        RuleFor<string>(x => x.AgentName).NotNull().NotEmpty();
		RuleFor<string>(x => x.Title).NotNull().NotEmpty();
		RuleFor<string>(x => x.Email).NotNull().NotEmpty().EmailAddress();
        //RuleFor<string>(x => x.AgentPhone1).NotNull().NotEmpty();//add phone match--- comment for now, there is data in db with no ph
        RuleFor<string>(x => x.UserId).NotNull().NotEmpty();//do already exists
		RuleFor<string>(x => x.Password)
			.NotEmpty().WithMessage(PasswordMessages.empty)
			.Matches("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)(?=.*[!@#$%^&*()_+{}\\[\\]:;<>,.?/~\\\\-]).*$").WithMessage(PasswordMessages.empty)
			.MinimumLength(8).WithMessage(PasswordMessages.lengthLow);
	}
}

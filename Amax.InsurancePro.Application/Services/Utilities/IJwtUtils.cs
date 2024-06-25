using Amax.InsurancePro.Domain.Entities;

namespace Amax.InsurancePro.Application.Services.Utilities;
public interface IJwtUtils
{
    Task<string> GenerateJwtToken(UserLoginInfo user);
    UserLoginInfo ValidateJwtToken(string token);
}
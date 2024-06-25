

using Amax.InsurancePro.Domain.Entities;

namespace Amax.InsurancePro.Domain.Interfaces;

public interface IUserRepository
{
    Task<string> Authenticate(AuthenticateRequest model);
    Task<UserLoginInfo> GetUserLoginInfo(AuthenticateRequest model);
    Task<bool> BlockUser(AuthenticateRequest request);
    Task<bool> ResetPassword(AuthenticateRequest request);
}
using Amax.InsurancePro.Application.Dtos;

namespace Amax.InsurancePro.Application.Services;
public interface IAuthService
{
    //Task<string> Authenticate(AuthenticateRequestDto request);
    //Task<AuthenticateResponseDto> GetUserLoginInfo(AuthenticateRequestDto request);
    Task<bool> BlockUser(AuthenticateRequestDto request);
    Task<bool> ResetPassword(AuthenticateRequestDto request);
    Task<AuthenticateResponseDto> Login(AuthenticateRequestDto requestDto);

}

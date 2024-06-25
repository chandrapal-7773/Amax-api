namespace Amax.InsurancePro.Application.Services;

public interface ISettingService
{
    Task<DateTime> GetServerTime();
}

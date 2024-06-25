namespace Amax.InsurancePro.Domain.Interfaces;

public interface ISettingRepository
{
    Task<DateTime> GetServerTime();
}
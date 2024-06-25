using Amax.InsurancePro.Domain.Interfaces;

namespace Amax.InsurancePro.Application.Services;
public class SettingService : ISettingService
{
    private readonly ISettingRepository _repo;

    public SettingService(
        ISettingRepository repo)
    {
        _repo = repo;
    }

    public async Task<DateTime> GetServerTime()
    {
        return await _repo.GetServerTime();
    }

}
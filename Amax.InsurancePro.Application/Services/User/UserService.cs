using Amax.InsurancePro.Application.Services.Utilities;
using Amax.InsurancePro.Domain.Interfaces;
using AutoMapper;

namespace Amax.InsurancePro.Application.Services;

public class UserService : IUserService
{
    private readonly IAgentRepository _arepo;
    private readonly IUserRepository _repo;
    private readonly IJwtUtils _jwtUtils;
    private readonly IMapper _mapper;

    public UserService(
        IUserRepository repo,
        IAgentRepository aRepo,
        IJwtUtils jwtUtils,
        IMapper mapper)
    {
        _repo = repo;
        _arepo = aRepo;
        _jwtUtils = jwtUtils;
        _mapper = mapper;
    }



}
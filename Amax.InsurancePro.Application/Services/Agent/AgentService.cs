using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Validation;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Exceptions.Business;
using Amax.InsurancePro.Domain.Interfaces;
using AutoMapper;
using FluentValidation;

namespace Amax.InsurancePro.Application.Services;

public class AgentService : IAgentService
{
    private readonly IAgentRepository _repo;
	private readonly IMapper _mapper;
    private readonly IValidator<AgentDto> _validator;

	public AgentService(IAgentRepository repo, IMapper mapper, IValidator<AgentDto> validator)
    {
        _repo = repo;
        _mapper = mapper;
        _validator = validator;
    }

    public async Task<AgentDto> Get(long id)
    {
        var agent = await _repo.Get(id);

		return _mapper.Map<AgentDto>(agent);
    }

    public async Task<AgentDto> GetByUserId(string userId)
    {
		var agent = _repo.GetByUserId(userId);

		return _mapper.Map<AgentDto>(agent);
	}

    public async Task<AgentsDto> GetAll(TableParameterDto requestDto)
    {
        var agents = await _repo.GetAll(_mapper.Map<TableParameter>(requestDto));

        var result = _mapper.Map<AgentsDto>(agents);

        return result;
    }

    public async Task<ResultDto> Add(AgentDto requestDto, long userId, string loginId)
    {
        await _validator.ValidateAndThrowAsync(requestDto);

        var agent = _mapper.Map<AgentInfo>(requestDto);

        var result = await _repo.Add(loginId, agent);

        return _mapper.Map<ResultDto>(result);
    }

    public async Task<ResultDto> Update(AgentDto requestDto, long userId, string loginId)
    {
		await _validator.ValidateAndThrowAsync(requestDto);

		var agentDto = await Get(requestDto.AgentId);

        if (agentDto == null)
            throw new ResourceNotFoundException("Agent Not Found");

        var agent = _mapper.Map<AgentInfo>(requestDto);

        var result = await _repo.Update(loginId, agent);

        return _mapper.Map<ResultDto>(result);
    }

    public async Task<ResultDto> Delete(long id, long userId, string loginId)
    {
		var agentDto = await Get(id);

		if (agentDto == null)
			throw new ResourceNotFoundException("Agent Not Found");

		var result = await _repo.Delete(id, userId);

        return _mapper.Map<ResultDto>(result);
    }
}
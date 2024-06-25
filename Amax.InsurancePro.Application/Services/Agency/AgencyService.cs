using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Validation;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Exceptions.Business;
using Amax.InsurancePro.Domain.Interfaces;
using AutoMapper;
using FluentValidation;

namespace Amax.InsurancePro.Application.Services;

public class AgencyService : IAgencyService
{
    private readonly IAgencyRepository _repo;
	private readonly IMapper _mapper;
    private readonly IValidator<AgencyDto> _validator;

	public AgencyService(IAgencyRepository repo, IMapper mapper, IValidator<AgencyDto> validator)
    {
        _repo = repo;
        _mapper = mapper;
        _validator = validator;
    }

	public async Task<AgencyDto> Get(long id)
	{
		var agency = await _repo.Get(id);

		return _mapper.Map<AgencyDto>(agency);
	}

	public async Task<AgenciesDto> GetAll(TableParameterDto requestDto)
    {
        var agents = await _repo.GetAll(_mapper.Map<TableParameter>(requestDto));

        var result = _mapper.Map<AgenciesDto>(agents);

        return result;
    }

	public async Task<ResultDto> Add(AgencyDto requestDto, long userId, string loginId)
	{
		await _validator.ValidateAndThrowAsync(requestDto);

		var agency = _mapper.Map<AgencyInfo>(requestDto);

		var result = await _repo.Add(loginId, agency);

		return _mapper.Map<ResultDto>(result);
	}

	public async Task<ResultDto> Update(AgencyDto requestDto, long userId, string loginId)
	{
		await _validator.ValidateAndThrowAsync(requestDto);

		var companyDto = await Get(requestDto.AgencyId);

		if (companyDto == null)
			throw new ResourceNotFoundException("Agency Not Found");

		var agency = _mapper.Map<AgencyInfo>(requestDto);

		var result = await _repo.Update(loginId, agency);

		return _mapper.Map<ResultDto>(result);
	}

	public async Task<ResultDto> Delete(long id, long userId, string loginId)
	{
		var companyDto = await Get(id);

		if (companyDto == null)
			throw new ResourceNotFoundException("Agency Not Found");

		var result = await _repo.Delete(id, userId);

		return _mapper.Map<ResultDto>(result);
	}
}
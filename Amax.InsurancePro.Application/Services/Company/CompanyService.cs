using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Validation;
using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Exceptions.Business;
using Amax.InsurancePro.Domain.Interfaces;
using Amax.InsurancePro.Repository;
using AutoMapper;
using FluentValidation;

namespace Amax.InsurancePro.Application.Services;

public class CompanyService : ICompanyService
{
	private readonly ICompanyRepository _repo;
	private readonly IMapper _mapper;
	private readonly IValidator<CompanyDto> _validator;

	public CompanyService(ICompanyRepository repo, IMapper mapper, IValidator<CompanyDto> validator)
	{
		_repo = repo;
		_mapper = mapper;
		_validator = validator;
	}

	public async Task<CompanyDto> Get(long id)
	{
		var company = await _repo.Get(id);

		return _mapper.Map<CompanyDto>(company);
	}

	public async Task<CompaniesDto> GetAll(TableParameterDto requestDto)
	{
		var companies = await _repo.GetAll(_mapper.Map<TableParameter>(requestDto));

		var result = _mapper.Map<CompaniesDto>(companies);

		return result;
	}

	public async Task<ResultDto> Add(CompanyDto requestDto, long userId, string loginId)
	{
		await _validator.ValidateAndThrowAsync(requestDto);

		var company = _mapper.Map<CompanyInfo>(requestDto);

		var result = await _repo.Add(loginId, company);

		return _mapper.Map<ResultDto>(result);
	}

	public async Task<ResultDto> Update(CompanyDto requestDto, long userId, string loginId)
	{
		await _validator.ValidateAndThrowAsync(requestDto);

		var companyDto = await Get(requestDto.CompanyID);

		if (companyDto == null)
			throw new ResourceNotFoundException("Company Not Found");

		var company = _mapper.Map<CompanyInfo>(requestDto);

		var result = await _repo.Update(loginId, company);

		return _mapper.Map<ResultDto>(result);
	}

	public async Task<ResultDto> Delete(long id, long userId, string loginId)
	{
		var companyDto = await Get(id);

		if (companyDto == null)
			throw new ResourceNotFoundException("Company Not Found");

		var result = await _repo.Delete(id, userId);

		return _mapper.Map<ResultDto>(result);
	}
}

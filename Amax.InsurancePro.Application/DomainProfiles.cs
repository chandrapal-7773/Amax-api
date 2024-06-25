using Amax.InsurancePro.Application.Dtos;

using Amax.InsurancePro.Domain.Entities;
using Amax.InsurancePro.Domain.Entities.Custom;
using Amax.InsurancePro.Domain.Shared;
using AutoMapper;


namespace Amax.InsurancePro.Application
{
	public class DomainProfiles: Profile
	{
		public DomainProfiles()
		{
			
			CreateMap<Result, ResultDto>().ReverseMap();
			CreateMap<TableParameter, TableParameterDto>().ReverseMap();

			
			CreateMap<AuthenticateRequestDto, AuthenticateRequest>().ReverseMap();
			CreateMap<LoginInfoDto, UserLoginInfo>().ReverseMap();

			
			MapAgent();
			MapAgency();
			MapCompany();

		}

		private void MapAgent()
		{
			CreateMap<AgentRightsDto, AgentRights>().ReverseMap();

			CreateMap<AgentInfo, AgentDto>()
				.ForMember(dest => dest.AdminAccess, opt => opt.MapFrom(src => src.AdminAccess == 1 ? true : false))
				.ForMember(dest => dest.AccessReport, opt => opt.MapFrom(src => src.AccessReport == 1 ? true : false))
				.ForMember(dest => dest.AccessDeletePay, opt => opt.MapFrom(src => src.AccessDeletePay == 1 ? true : false))
				.ForMember(dest => dest.AccessDaily, opt => opt.MapFrom(src => src.AccessDaily == 1 ? true : false))
				.ForMember(dest => dest.AccessSetupAgency, opt => opt.MapFrom(src => src.AccessSetupAgency == 1 ? true : false))
				.ForMember(dest => dest.AccessReconcile, opt => opt.MapFrom(src => src.AccessReconcile == 1 ? true : false))
				.ForMember(dest => dest.AccessWriteCheck, opt => opt.MapFrom(src => src.AccessWriteCheck == 1 ? true : false))
				.ForMember(dest => dest.AccessPost, opt => opt.MapFrom(src => src.AccessPost == 1 ? true : false))
				.ForMember(dest => dest.AccessDelPayClients, opt => opt.MapFrom(src => src.AccessDelPayClients == 1 ? true : false))
				.ForMember(dest => dest.AccesEodreports, opt => opt.MapFrom(src => src.AccesEodreports == 1 ? true : false))
				.ForMember(dest => dest.AccessAgencyFees, opt => opt.MapFrom(src => src.AccessAgencyFees == 1 ? true : false))
				.ForMember(dest => dest.Prefill, opt => opt.MapFrom(src => src.Prefill == 1 ? true : false))
				.ForMember(dest => dest.ResetPassword, opt => opt.MapFrom(src => src.ResetPassword == 1 ? true : false))
				.ForMember(dest => dest.BLocked, opt => opt.MapFrom(src => src.BLocked == 1 ? true : false))
				.ReverseMap();
			CreateMap<TableResponse<AgentInfo>, AgentsDto>(MemberList.Destination)
			.ForMember(x => x.Data, opt => opt.MapFrom(src => src.Data));

			CreateMap<AgentLocations, AgentLocationsDto>().ReverseMap();
		}
		
		private void MapAgency()
		{
			CreateMap<AgencyInfo, AgencyDto>().ReverseMap();
			CreateMap<TableResponse<AgencyInfo>, AgenciesDto>(MemberList.Destination)
			.ForMember(x => x.Data, opt => opt.MapFrom(src => src.Data));
		}
		private void MapCompany()
		{
			CreateMap<CompanyInfo, CompanyDto>()
				.ForMember(dest => dest.CollectCommOnFees, opt => opt.MapFrom(src => src.CollectCommOnFees == 1 ? true : false))
				.ReverseMap();
			CreateMap<TableResponse<CompanyInfo>, CompaniesDto>(MemberList.Destination)
				.ForMember(x => x.Data, opt => opt.MapFrom(src => src.Data));
		}

	}
}

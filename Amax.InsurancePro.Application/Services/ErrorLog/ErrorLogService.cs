


using Amax.InsurancePro.Application.Dtos;


namespace Amax.InsurancePro.Application.Services;


public class ErrorLogService : IErrorLogService
    {
        //private IErrorLogRepository _repo;

        //public ErrorLogService(IErrorLogRepository repo)
        //{
        //    _repo = repo;
        //}

        public async Task<ErrorLogDto> Log(ErrorLogDto request)
        {
            var response = new ErrorLogDto();
            //int recordsAffected = await _repo.Log(request);
            //if (recordsAffected > 0)
            //{
            //    response.Success = true;
            //}
            return response;
        }
    }

using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Amax.InsurancePro.API.Controllers;

[Authorize]
public class ErrorLogController : BaseController
{
    private IErrorLogService _service;

    public ErrorLogController(IErrorLogService service)
    {
        _service = service;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> LogError(ErrorLogDto request)
    {
        //ErrorLogResponseDto response = new ErrorLogResponseDto();
        //Exception ex = request.Exception.GetBaseException();
        //request.ErrorLog.ErrorMessage = ex.Message;
        //request.ErrorLog.StackTrace = ex.StackTrace;
        //if (request.IsDBLog)
        //{
        //    response = await _service.Log(request);
        //}
        //response.Success = false;
        //response.Message = "Something went wrong!";
        //return Ok(response);

        return Ok("GGG");
    }

}

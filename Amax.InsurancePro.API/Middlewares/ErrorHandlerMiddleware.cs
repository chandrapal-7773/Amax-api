namespace Amax.InsurancePro.API.Middlewares;

using Amax.InsurancePro.API.Models;

using Amax.InsurancePro.Application.Services;
using Amax.InsurancePro.Domain.Common;
using Amax.InsurancePro.Domain.Exceptions.Business;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

public class ErrorHandlerMiddleware
{
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context, IErrorLogService errorLog)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {
            var response = context.Response;
            response.ContentType = "application/json";

			var errResponse = new ErrorResponse
			{
				Code = 0,
				Message = String.Empty,
			};

			switch (error)
            {
                case ValidationException e:
					response.StatusCode = (int)HttpStatusCode.BadRequest;
					errResponse.ValidationErrors = e.Errors.ToList()
                        .Select(e => new ValidationError
                        {
							PropertyName = e.PropertyName,
                            ErrorMessage = e.ErrorMessage
                        })
                        .ToList();
                    break;
				case ResourceNotFoundException e:
					response.StatusCode = e.Code;
					break;
				case BusinessException e:
                    response.StatusCode = e.Code;
                    break;
				case AppException e:
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                default:
                    response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            errResponse.Code = response.StatusCode;
			errResponse.Message = error.Message;

            var result = JsonSerializer.Serialize(errResponse);
            await response.WriteAsync(result);
        }
    }
}
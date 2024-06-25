using Amax.InsurancePro.API.Models;
using Amax.InsurancePro.Application.Dtos;
using Amax.InsurancePro.Domain.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Amax.InsurancePro.API.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AccessRightAttribute : Attribute, IActionFilter
{
    private readonly string _accessRightProperty = string.Empty;

    public AccessRightAttribute(string accessRightProperty)
    {
        _accessRightProperty = accessRightProperty;
    }

    public void OnActionExecuting(ActionExecutingContext filterContext)
    {
        bool allowed = false;
        var context = filterContext.HttpContext;
        var user = (LoginInfoDto)context.Items["User"];
        if (user != null)
        {
            var agentRights = user.AgentRights;
            if (agentRights != null)
            {
                var value = agentRights.GetValue(_accessRightProperty);
                if (value != null)
                {
                    bool.TryParse(value.ToString(), out allowed);
                }
            }
        }
        if (!allowed)
        {
            var errResponse = new ErrorResponse
			{
                Code = StatusCodes.Status401Unauthorized,
                Message = "You are unauthorized to perform this operation",
            };
            filterContext.Result = new JsonResult(errResponse) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }

    public void OnActionExecuted(ActionExecutedContext filterContext)
    {
        //throw new NotImplementedException();
    }
}
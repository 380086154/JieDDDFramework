﻿using JieDDDFramework.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace JieDDDFramework.Web.Filters
{
    public class ValidateModelStateFilter :  IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid)
            {
                return;
            }
            var result = new ModelErrorResult(context.ModelState);
            context.Result = new BadRequestObjectResult(result);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}

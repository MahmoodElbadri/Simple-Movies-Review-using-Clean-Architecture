using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Movie_Review_Website.Filters
{
    public class ValidateSearchAttribute : ActionFilterAttribute
    {
        private ILogger<ValidateSearchAttribute>? _logger;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Resolve the logger from the IServiceProvider (DI)
            _logger = context.HttpContext.RequestServices.GetService<ILogger<ValidateSearchAttribute>>();

            _logger?.LogInformation("Inside OnActionExecuting in the action filter");

            // Check if "searchString" exists in ActionArguments
            if (context.ActionArguments.ContainsKey("searchString"))
            {
                var searchString = context.ActionArguments["searchString"] as string;

                // Check if the search string is null or empty
                if (string.IsNullOrEmpty(searchString))
                {
                    _logger?.LogWarning("Search string is null or empty.");
                    // If invalid, show all movies or a message (instead of redirecting)
                    context.Result = new RedirectToActionResult("Index", "Movies", null);
                }
                else
                {
                    _logger?.LogInformation($"{searchString} is valid");
                }
            }
            else
            {
                _logger?.LogWarning("The searchString key was not found in ActionArguments.");
            }

            // Proceed with the action
            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            // Optional: logic after the action is executed
        }
    }
}

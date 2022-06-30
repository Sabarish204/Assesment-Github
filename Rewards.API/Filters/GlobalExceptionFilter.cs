using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Rewards.API.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        protected readonly ILogger<GlobalExceptionFilter> _logger;
        public GlobalExceptionFilter(ILogger<GlobalExceptionFilter> logger) { _logger = logger; }
        public void OnException(ExceptionContext context)
        {
            _logger.LogInformation("==================================Exception Occured========================================");
            _logger.LogError(context.Exception.ToString());
            _logger.LogError(context.Exception.StackTrace);
            string json = JsonConvert.SerializeObject(context.ModelState.Values, Formatting.Indented);
            _logger.LogInformation(json);
        }
    }
}
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Serilog;

namespace Rewards.API.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public GlobalExceptionFilter() { }
        public void OnException(ExceptionContext context)
        {
            Log.Information("==================================Exception Occured========================================");
            Log.Error(context.Exception.ToString());
            Log.Error(context.Exception.StackTrace);
            var json = JsonConvert.SerializeObject(context.ModelState.Values, Formatting.Indented);
            Log.Information(json);
        }
    }
}

using Microsoft.Extensions.Hosting.Internal;
using WebApiMIddleware.Data;
using WebApiMIddleware.Models;

namespace WebApiMIddleware.Middlewares
{
    public class ErrorHandler
    {
        private readonly RequestDelegate requestDelegate;

        public ErrorHandler(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;

        }

        public async Task InvokeAsync(HttpContext context, ApplicationContext applicationContext)
        {
            try
            {
                await requestDelegate(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;

                var errorInfo = new ErrorInfo()
                {
                    StatusCode = context.Response.StatusCode,
                    ErrorMessage = ex.Message
                };

                var errorLog = new ErrorLogger()
                {
                    ErrorDetails = errorInfo.ErrorMessage,
                    LogDate = DateTime.Now
                };
                await applicationContext.ErrorLogger.AddAsync(errorLog);
                await applicationContext.SaveChangesAsync();

                await context.Response.WriteAsJsonAsync<ErrorInfo>(errorInfo);
            }
        }
    }
}

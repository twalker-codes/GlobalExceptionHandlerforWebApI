using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class NotFoundExceptionHandler(ILogger<ProductNotFoundException> logger) : IExceptionHandler
{
     public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
         if(exception is not ProductNotFoundException e)
         {
            return false;
         }    

         var problemDetails = new ProblemDetails()
         {
             Instance = httpContext.Request.Path,
             Title = exception.Message   
         };

         httpContext.Response.StatusCode = (int)e.StatusCode;
         logger.LogError("{ProblemDetailsTitle}", problemDetails.Title);
         problemDetails.Status = httpContext.Response.StatusCode;
         await httpContext.Response.WriteAsJsonAsync(problemDetails, cancellationToken);
         return true;
    }
}

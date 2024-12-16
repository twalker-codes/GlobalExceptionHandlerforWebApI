using System.Net;
using Microsoft.AspNetCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddExceptionHandlers();

// use this error handler for .NET < 8
//app.UseMiddleware<ErrorHandlerMiddleware>();

var app = builder.Build();

app.UseExceptionHandler();

app.MapGet("/product", () =>
{
    throw new ProductNotFoundException(Guid.NewGuid());
});

app.Run();
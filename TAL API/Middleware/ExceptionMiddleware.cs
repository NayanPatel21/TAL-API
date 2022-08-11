using Microsoft.AspNetCore.Http;
using System;
using System.Net;
using System.Threading.Tasks;
using TAL.LoggerService;
using TAL.Common.Models;

namespace TAL_API.Middleware
{
	public class ExceptionMiddleware
	{
		private readonly RequestDelegate _next;
		private readonly ILoggerManager _logger;

		public ExceptionMiddleware(RequestDelegate next, ILoggerManager logger)
		{
			_logger = logger;
			_next = next;
		}

		public async Task InvokeAsync(HttpContext httpContext)
		{
			try
			{
				await _next(httpContext);
			}
			catch (AccessViolationException avEx)
			{
				_logger.LogError(Constants.TAL_API_LogError1 + avEx);
				await HandleExceptionAsync(httpContext, avEx);
			}
			catch (Exception ex)
			{
				_logger.LogError(Constants.TAL_API_LogError + ex);
				await HandleExceptionAsync(httpContext, ex);
			}
		}

		private async Task HandleExceptionAsync(HttpContext context, Exception exception)
		{
			context.Response.ContentType = Constants.TAL_API_ContentType;
			context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

			var message = exception switch
			{
				AccessViolationException => Constants.TAL_API_LogError2,
				_ => Constants.TAL_API_LogError3
			};

			await context.Response.WriteAsync(new ErrorDetails()
			{
				StatusCode = context.Response.StatusCode,
				Message = message
			}.ToString());
		}
	}
}

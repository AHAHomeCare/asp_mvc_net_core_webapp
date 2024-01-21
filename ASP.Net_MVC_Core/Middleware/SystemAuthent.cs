using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
namespace ASP.Net_MVC_Core.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class SystemAuthent
    {
        private readonly RequestDelegate _next;
        private readonly ISession _session;
        public SystemAuthent(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.User.Identity.IsAuthenticated)
            {
                await _next.Invoke(httpContext);
                return;
            }
            var userName = httpContext.Session.GetString("user_id"); // httpContext.Request.Headers["user_name"];  //httpContext.User.Identity.Name;
            if (!string.IsNullOrEmpty(userName)) // userName = "anonymous";
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, userName),
                    // Add additional claims as needed
                };
                var identity = new ClaimsIdentity(claims, "SystemAuth");
                var principal = new ClaimsPrincipal(identity);
                httpContext.User = principal;

            }
            else
                httpContext.User = new ClaimsPrincipal();

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class AuthentExtensions
    {
        public static IApplicationBuilder UseMiddlewareSystemAuthent(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SystemAuthent>();
        }
    }
}


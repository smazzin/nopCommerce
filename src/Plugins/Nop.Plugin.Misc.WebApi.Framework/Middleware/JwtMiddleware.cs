using System.Text;
using Microsoft.AspNetCore.Http;
using Nop.Core;
using Nop.Services.Customers;
using System.IdentityModel.Tokens.Jwt;
using Nop.Core.Infrastructure;
using Microsoft.IdentityModel.Tokens;

namespace Nop.Plugin.Misc.WebApi.Framework.Middleware;

/// <summary>
/// The custom JWT middleware
/// </summary>
public class JwtMiddleware
{
    private readonly RequestDelegate _next;

    public JwtMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IWorkContext workContext, ICustomerService customerService)
    {
        var token = context.Request.Headers[WebApiCommonDefaults.SecurityHeaderName].FirstOrDefault()?.Split(" ").Last();

        if (token != null)
            await AttachUserToContextAsync(context, workContext, customerService, token);

        await _next(context);
    }

    private async Task AttachUserToContextAsync(HttpContext context, IWorkContext workContext, ICustomerService customerService, string token)
    {
        try
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var settings = EngineContext.Current.Resolve<WebApiCommonSettings>();
            var key = Encoding.UTF8.GetBytes(settings.SecretKey);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                //set clock skew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out var validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var customerId = int.Parse(jwtToken.Claims.First(x => x.Type == WebApiCommonDefaults.ClaimTypeName).Value);

            var customer = await customerService.GetCustomerByIdAsync(customerId);

            if (customer == null || customer.Deleted || !customer.Active || customer.RequireReLogin )
                //if customer not exist or is deleted/inactive or should re login
                //not attached customer to context
                //so request won't have access to secure routes
                //and customer gets Unauthorized response see AuthorizeAttribute class
                return;

            //attach customer to context on successful jwt validation
            await workContext.SetCurrentCustomerAsync(customer);
            context.Items[WebApiCommonDefaults.CustomerKey] = customer;
        }
        catch
        {
            //do nothing if jwt validation fails
            //customer is not attached to context
            //so request won't have access to secure routes
            //and customer gets Unauthorized response see AuthorizeAttribute class
        }
    }
}
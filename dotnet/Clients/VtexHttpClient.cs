using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Vtex.Api.Context;

namespace DotNetService.Clients
{
    public static class VtexHttpClient
    {
        private const string AuthorizationHeader = "VtexIdclientAutCookie";
        private const string UseHttpsHeader = "X-Vtex-Use-Https";

        public static void Configure(IServiceProvider serviceProvider, HttpClient client)
        {
            // The service context provides meta information about the app and its environment 
            var serviceContext = serviceProvider.GetService<IIOServiceContext>();
            
            // So we use it to configure the base url for our core commerce api client
            var baseUri = "https://vtexid.vtexcommercestable.com.br";
                
            if (!Uri.TryCreate($"{baseUri}", UriKind.Absolute, out var uri))
                throw new Exception($"Invalid Vtex baseUri: {baseUri}");
            
            client.BaseAddress = uri;

            // Here we ensure we are relaying the correct header parameters for the app to work
            client.DefaultRequestHeaders.Add(AuthorizationHeader, serviceContext.Vtex.AuthToken);
            client.DefaultRequestHeaders.Add(UseHttpsHeader, "true");
            client.DefaultRequestHeaders.Add("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            client.DefaultRequestHeaders.Add("Cookie", "VtexIdclientAutCookie=eyJhbGciOiJFUzI1NiIsImtpZCI6IjhCMjY5MjAwRUZDNkZEM0UwRjRFRDU2MTE2RTlFOTYwQTAzQ0Y5OEEiLCJ0eXAiOiJqd3QifQ.eyJzdWIiOiJ2dGV4YXBwa2V5LWRlY29yZXN0LVZJV0FEViIsImFjY291bnQiOiJ2dGV4IiwiYXVkaWVuY2UiOiJhZG1pbiIsImV4cCI6MTYzNTY4MDkzMywidXNlcklkIjoiNDI0MmY3ZmUtNjFkOC00MzY2LThiZDAtZGI1YWNmMzk5YTZmIiwiaWF0IjoxNjM1NjU5MzMzLCJpc3MiOiJ0b2tlbi1lbWl0dGVyIiwianRpIjoiOWIxNTE0YzYtYjRlNi00NDdhLWE1NDAtMjAyMzgxZTY4OGYzIn0.7UMphYVT0ocaR2nO_Q7NXZ2W4fLWKtgZQtk2ylfoeWENeyvydmZ3KJGVx_f2Pzr-rEiHeidy-JIfXj5QXVSxEQ;");
        }
    }
}
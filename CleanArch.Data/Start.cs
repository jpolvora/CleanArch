using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Auth;
using CleanArch.Domain.UseCases.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Data
{
    public static class Start
    {
        public static void AddDataLayer(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IAuthenticationService, RemoteAuthentication>();
        }
    }
}
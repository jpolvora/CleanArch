using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.UseCases.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Domain
{
    public static class Start
    {
        public static IServiceCollection AddDomainLayer(this IServiceCollection services)
        {
            return services.AddScoped<AuthenticationUseCase>();
        }
    }
}
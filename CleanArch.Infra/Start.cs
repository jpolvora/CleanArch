using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Shared;
using CleanArch.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra
{
    public static class Start
    {
        public static void AddInfrastructureLayer(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IHttpPostClient<>), typeof(DefaultHttpClient<>));
            serviceCollection.AddScoped(typeof(IHttpPostClient<>), typeof(DefaultHttpClient<>));
        }
    }

}
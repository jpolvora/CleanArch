using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Shared;
using CleanArch.Domain.Auth;

namespace CleanArch.Data.Authentication
{
    public class RemoteAuthentication : IAuthenticationService
    {
        public IHttpPostClient<AuthenticationUseCaseResult> HttpPostClient { get; }
        public RemoteAuthentication(IHttpPostClient<AuthenticationUseCaseResult> httpPostClient)
        {
            this.HttpPostClient = httpPostClient;

        }

        public async Task<string> Login(string userName, string password)
        {
            await Task.Delay(1000);
            return userName == password ? Guid.NewGuid().ToString() : "";
        }
    }
}
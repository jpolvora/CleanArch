using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Shared;
using CleanArch.Domain.Auth;

namespace CleanArch.Data.Authentication
{
    public class RemoteAuthentication : IAuthentication
    {
        public IHttpPostClient<AuthenticationResult> HttpPostClient { get; }
        public RemoteAuthentication(IHttpPostClient<AuthenticationResult> httpPostClient)
        {
            this.HttpPostClient = httpPostClient;

        }

        public Task<string> Execute(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
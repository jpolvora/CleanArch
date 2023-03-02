using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Data.Shared;
using CleanArch.Domain.UseCases.Auth;

namespace CleanArch.Data.Auth
{
    public class RemoteAuthentication : IAuthenticationService
    {
        public async Task<string> Login(string userName, string password)
        {
            await Task.Delay(1000);
            return userName == password ? Guid.NewGuid().ToString() : "";
        }
    }
}
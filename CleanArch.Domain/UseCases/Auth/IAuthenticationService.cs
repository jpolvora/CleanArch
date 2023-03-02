using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Shared;

namespace CleanArch.Domain.UseCases.Auth
{
    public interface IAuthenticationService
    {
        ///
        ///Retorna o token para acesso as API's 
        ///
        Task<string> Login(string userName, string password);
    }
}
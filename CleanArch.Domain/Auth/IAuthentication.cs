using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Shared;

namespace CleanArch.Domain.Auth
{
    public interface IAuthentication
    {
        ///
        ///Retorna o token para acesso as API's 
        ///
        Task<string> Execute(string userName, string password);
    }
}
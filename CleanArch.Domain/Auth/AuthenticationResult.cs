using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Auth
{
    public class AuthenticationResult
    {
        public string Token { get; }

        public List<string> Errors { get; }

        public AuthenticationResult(List<string> errors, string token)
        {
            Errors = errors;
            Token = token;
        }

    }
}
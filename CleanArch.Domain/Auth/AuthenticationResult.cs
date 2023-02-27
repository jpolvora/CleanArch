using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Auth
{
    public class AuthenticationUseCaseResult
    {
        public string Token { get; } = default!;

        public List<string> Errors { get; } = new();

        public AuthenticationUseCaseResult()
        {
        }

        public AuthenticationUseCaseResult(string token, List<string> errors)
        {
            Token = token;
            Errors = errors;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Shared;

namespace CleanArch.Domain.UseCases.Auth
{
    public class AuthenticationUseCaseResult : IUseCaseResult
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
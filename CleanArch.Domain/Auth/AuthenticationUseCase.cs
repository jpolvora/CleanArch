using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Shared;

namespace CleanArch.Domain.Auth
{
    public class AuthenticationUseCase : IUseCase<AuthenticationResult>
    {
        private readonly IAuthentication _authentication;

        public string? UserName { get; set; }
        public string? Password { get; set; }

        public AuthenticationUseCase(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public async Task<AuthenticationResult> Execute()
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                errors.Add("Informe o nome de usuário!");
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                errors.Add("Informe o nome de usuário!");
            }

            string token = string.Empty;
            if (errors.Count == 0)
            {
                token = await _authentication.Execute(UserName!, Password!);
                if (string.IsNullOrWhiteSpace(token))
                {
                    errors.Add("Usuário e/ou Senha inválidos");
                }
            }


            return new AuthenticationResult(errors, token);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Shared;

namespace CleanArch.Domain.Auth
{
    public class AuthenticationUseCase : IUseCase<AuthenticationUseCaseResult>
    {
        private readonly IAuthentication _authentication;

        public string UserName { get; private set; } = default!;
        public string Password { get; private set; } = default!;

        public AuthenticationUseCase(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public void SetCredentials(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public async Task<AuthenticationUseCaseResult> Execute()
        {
            var token = string.Empty;
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                errors.Add("Informe o nome de usuário!");
            }

            if (string.IsNullOrWhiteSpace(Password))
            {
                errors.Add("Informe a senha!");
            }

            if (errors.Count == 0)
            {
                token = await _authentication.Execute(UserName!, Password!);
                if (string.IsNullOrWhiteSpace(token))
                {
                    errors.Add("Usuário e/ou Senha inválidos");
                }
            }

            return new AuthenticationUseCaseResult(token, errors);
        }
    }
}
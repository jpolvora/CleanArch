using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Shared;

namespace CleanArch.Domain.UseCases.Auth
{
    public sealed class AuthenticationUseCase : IUseCase<AuthenticationUseCaseResult>
    {
        private readonly IAuthenticationService _authenticationService;

        public string UserName { get; private set; } = default!;
        public string Password { get; private set; } = default!;

        public AuthenticationUseCase(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public void SetCredentials(string userName, string password)
        {
            UserName = userName ?? string.Empty;
            Password = password ?? string.Empty;
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

            if (!errors.Any())
            {
                token = await _authenticationService.Login(UserName!, Password!);
                if (string.IsNullOrWhiteSpace(token))
                {
                    errors.Add("Usuário e/ou Senha inválidos");
                }
            }

            return new AuthenticationUseCaseResult(token, errors);
        }
    }
}
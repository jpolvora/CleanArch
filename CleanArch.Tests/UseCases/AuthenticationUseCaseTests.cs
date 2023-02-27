using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

using CleanArch.Domain.Auth;

namespace CleanArch.Tests.UseCases
{
    public class AuthenticationUseCaseTests
    {
        private class FakeAuthenticationService : IAuthenticationService
        {
            public Task<string> Login(string userName, string password)
            {
                if (string.IsNullOrEmpty(userName)) return Task.FromResult(string.Empty);
                if (string.IsNullOrEmpty(password)) return Task.FromResult(string.Empty);

                return Task.FromResult(Guid.NewGuid().ToString());
            }
        }

        [Fact]
        public async Task ShouldSucceed()
        {
            var authenticationService = new FakeAuthenticationService();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("jpolvora@gmail.com", "123456");

            var result = await sut.Execute();

            Assert.Empty(result.Errors);
            Assert.NotNull(result.Token);
        }

        [Fact]
        public async Task ShouldFail()
        {
            var authenticationService = new FakeAuthenticationService();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("jpolvora@gmail.com", "");
            var result = await sut.Execute();
            Assert.True(result.Errors.Count == 1);
            Assert.True(string.IsNullOrEmpty(result.Token));
        }
    }
}
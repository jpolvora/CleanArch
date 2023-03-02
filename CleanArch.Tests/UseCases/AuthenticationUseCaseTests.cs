using CleanArch.Domain.UseCases.Auth;
using CleanArch.Data.Auth;

namespace CleanArch.Tests.UseCases
{
    public class AuthenticationUseCaseTests
    {
        [Fact]
        public async Task ShouldSucceedWhenUsernameAndPasswordAreSame()
        {
            var authenticationService = new RemoteAuthentication();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("jpolvora@gmail.com", "jpolvora@gmail.com");

            var result = await sut.Execute();

            Assert.Empty(result.Errors);
            Assert.NotNull(result.Token);
        }

        [Fact]
        public async Task ShouldFailWhenUsernameAndPasswordAreNotSame()
        {
            var authenticationService = new RemoteAuthentication();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("jpolvora@gmail.com", "123456");

            var result = await sut.Execute();

            Assert.True(result.Errors.Count == 1);

            Assert.True(string.IsNullOrEmpty(result.Token));
        }

        [Fact]
        public async Task ShouldFailIfPasswordIsEmpty()
        {
            var authenticationService = new RemoteAuthentication();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("jpolvora@gmail.com", "");
            var result = await sut.Execute();
            Assert.True(result.Errors.Count == 1);
            Assert.True(string.IsNullOrEmpty(result.Token));
        }

        [Fact]
        public async Task ShouldFailIfUsernameIsEmpty()
        {
            var authenticationService = new RemoteAuthentication();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("", "123456");
            var result = await sut.Execute();
            Assert.True(result.Errors.Count == 1);
            Assert.True(string.IsNullOrEmpty(result.Token));
        }

        [Fact]
        public async Task ShouldFailIfUsernameAndPasswordNotProvided()
        {
            var authenticationService = new RemoteAuthentication();
            var sut = new AuthenticationUseCase(authenticationService);
            sut.SetCredentials("", "");
            var result = await sut.Execute();
            Assert.True(result.Errors.Count == 2);
            Assert.True(string.IsNullOrEmpty(result.Token));
        }
    }
}
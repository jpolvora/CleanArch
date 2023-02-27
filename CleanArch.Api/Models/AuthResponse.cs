namespace CleanArch.Api.Models
{
    public class AuthResponse
    {
        public AuthResponse(string error, string token)
        {
            Error = error;
            Token = token;
        }
        public string Token { get; private set; }
        public string Error { get; private set; }
    }
}
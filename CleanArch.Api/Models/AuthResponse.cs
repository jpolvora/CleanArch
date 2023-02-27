namespace CleanArch.Api.Models
{
    public class AuthResponse
    {
        public AuthResponse(string token)
        {
            Token = token;
        }
        public string Token { get; private set; }
    }
}
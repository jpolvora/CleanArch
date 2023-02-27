namespace CleanArch.Api.Models
{
    public class AuthResponse
    {
        public string Token { get; }
        public List<string> Errors { get; }


        private AuthResponse(string token)
        {
            Token = token;
            Errors = new();
        }

        private AuthResponse(List<string> errors)
        {
            Token = string.Empty;
            Errors = errors;
        }

        public static AuthResponse Success(string token)
        {
            return new AuthResponse(token);
        }

        public static AuthResponse Fail(List<string> errors)
        {
            return new AuthResponse(errors);
        }
    }
}
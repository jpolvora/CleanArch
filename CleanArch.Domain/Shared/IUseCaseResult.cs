namespace CleanArch.Domain.Shared
{
    public interface IUseCaseResult
    {
        List<string> Errors { get; }
    }
}
using CleanArch.Data.Shared;
namespace CleanArch.Infra;

public class HttpClient<TResult> : IHttpPostClient<TResult>
{
    public Task<TResult> Post()
    {
        throw new NotImplementedException();
    }
}

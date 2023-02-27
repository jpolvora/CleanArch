using CleanArch.Data.Shared;
namespace CleanArch.Infra;

public class DefaultHttpClient<TResult> : IHttpPostClient<TResult>, IHttpGetClient<TResult> where TResult : class, new()
{
    public Task<TResult> Get(string url)
    {
        return Task.FromResult<TResult>(new());
    }

    public Task<TResult> Post(string url, IDictionary<string, string> headers, IDictionary<string, object> data)
    {
        return Task.FromResult<TResult>(new());
    }
}

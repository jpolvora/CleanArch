using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Data.Shared
{
    public interface IHttpPostClient<TResult>
    {
        Task<TResult> Post(string url, IDictionary<string, string> headers, IDictionary<string, object> data);
    }
}
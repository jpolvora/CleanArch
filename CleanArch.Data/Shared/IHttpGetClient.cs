using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Data.Shared
{
    public interface IHttpGetClient<TResult>
    {
        Task<TResult> Get(string url);
    }

}
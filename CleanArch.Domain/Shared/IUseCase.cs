using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Domain.Shared
{
    public interface IUseCase<TResult>
    {
        Task<TResult> Execute();
    }
}
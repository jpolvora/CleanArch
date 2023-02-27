using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArch.Data.Repository
{
    public interface IRepository<T> : IDisposable
    {
        IUnitOfWork UnitOfWork { get; set; }
    }
}
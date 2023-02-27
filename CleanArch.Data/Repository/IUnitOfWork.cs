namespace CleanArch.Data.Repository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Commit();
        Task RollBack();
    }
}
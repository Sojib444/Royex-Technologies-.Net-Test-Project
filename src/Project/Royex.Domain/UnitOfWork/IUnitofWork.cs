namespace Royex.Domain.UnitOfWork
{
    public interface IUnitofWork : IDisposable
    {
        Task SaveChangeAsync();
    }
}

namespace Royex.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetSingleAsync(int id,bool trackChange, CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(bool trackChange, CancellationToken cancellationToken);
    }
}

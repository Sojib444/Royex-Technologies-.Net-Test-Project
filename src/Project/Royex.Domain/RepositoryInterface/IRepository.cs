using System.Linq.Expressions;

namespace Royex.Domain.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetSingleAsync(int id,CancellationToken cancellationToken);
        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T,bool>> expression, bool trackChange, CancellationToken cancellationToken);
    }
}

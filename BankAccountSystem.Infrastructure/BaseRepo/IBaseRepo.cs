using System.Linq.Expressions;

namespace BankAccountSystem.Infrastructure.BaseRepo
{
    public interface IBaseRepo<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> conditionExpression);
        void Update(T entity);
        void Delete(T entity);
        void SoftDelete(T entity);
        Task SaveAsync(CancellationToken cancellationToken = default);

    }
}

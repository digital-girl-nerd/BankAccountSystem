using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem.Infrastructure.BaseRepo
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        //dependency injection
        public Task<T> CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }
        public void SoftDelete(T entity)
        {
            throw new NotImplementedException();
        }
        public IQueryable<T> GetByCondition(System.Linq.Expressions.Expression<Func<T, bool>> conditionExpression)
        {
            throw new NotImplementedException();
        }
        public Task SaveAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
    
}

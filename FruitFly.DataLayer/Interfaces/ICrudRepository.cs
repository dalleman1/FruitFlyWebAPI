using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Repository.Interfaces
{
    public interface ICrudRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<List<T>> GetAllAsync(bool tracking = false);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where, bool tracking = false);
        Task<List<T>> GetAllDescendingAsync(Expression<Func<T, bool>> where, bool tracking = false);
        Task<List<T>> GetAllOrderedAsync(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, bool descending = true, bool tracking = false);
        Task<T> GetByIdAsync(int id);
        Task<bool> RemoveAsync(int id);
        Task<bool> RemoveAsync(T entity);
        Task<bool> RemoveRangeAsync(List<T> entities);
        Task<bool> UpdateAsync(T entity);
    }
}

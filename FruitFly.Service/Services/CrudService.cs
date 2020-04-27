using FruitFly.Repository.Interfaces;
using FruitFly.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Service.Services
{
    public class CrudService<T> : ICrudService<T> where T : class
    {
        private readonly ICrudRepository<T> _crudRepository;
        public CrudService(ICrudRepository<T> crudRepository)
        {
            _crudRepository = crudRepository;
        }
        public async Task<T> AddAsync(T entity)
        {
            return await _crudRepository.AddAsync(entity);
        }

        public async Task<List<T>> GetAllAsync(bool tracking = false)
        {
            return await _crudRepository.GetAllAsync(tracking);
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where, bool tracking = false)
        {
            return await _crudRepository.GetAllAsync(where, tracking);
        }

        public async Task<List<T>> GetAllDescendingAsync(Expression<Func<T, bool>> where, bool tracking = false)
        {
            return await _crudRepository.GetAllDescendingAsync(where, tracking);
        }

        public async Task<List<T>> GetAllOrderedAsync(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, bool descending = true, bool tracking = false)
        {
            return await _crudRepository.GetAllOrderedAsync(where, order, descending, tracking);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _crudRepository.GetByIdAsync(id);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            return await _crudRepository.RemoveAsync(id);
        }

        public async Task<bool> RemoveAsync(T entity)
        {
            return await _crudRepository.RemoveAsync(entity);
        }

        public async Task<bool> RemoveAllAsync()
        {
            List<T> entities = await _crudRepository.GetAllAsync();
            return await _crudRepository.RemoveRangeAsync(entities);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            return await _crudRepository.UpdateAsync(entity);
        }

        public async Task<bool> RemoveRangeAsync(List<T> entities)
        {
            return await _crudRepository.RemoveRangeAsync(entities);
        }

        public async Task<bool> ReSeedTable(string tablename)
        {
            return await _crudRepository.ReSeedTable(tablename);
        }
    }
}

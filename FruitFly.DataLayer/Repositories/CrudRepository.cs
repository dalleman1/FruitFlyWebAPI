using FruitFly.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FruitFly.Repository.Repositories
{
    public abstract class CrudRepository<T> : ICrudRepository<T> where T : class
    {
        private readonly DbContext _context;

        public CrudRepository(DbContext context)
        {
            _context = context;
        }

        virtual public async Task<T> AddAsync(T entity)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        virtual public async Task<List<T>> GetAllAsync(bool tracking = false)
        {
            if (tracking)
                return await _context.Set<T>()
                                     .AsNoTracking()
                                     .ToListAsync();
            else
                return await _context.Set<T>()
                    .ToListAsync();
        }

        virtual public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>> where, bool tracking = false)
        {
            if (tracking)
                return await _context.Set<T>()
                                     .Where(where)
                                     .ToListAsync();
            else
                return await _context.Set<T>()
                                     .AsNoTracking()
                                     .Where(where)
                                     .ToListAsync();
        }

        virtual public async Task<List<T>> GetAllDescendingAsync(Expression<Func<T, bool>> where, bool tracking = false)
        {
            if (tracking)
                return await _context.Set<T>()
                    .Where(where)
                    .ToListAsync();
            else
                return await _context.Set<T>()
                    .AsNoTracking()
                    .Where(where)
                    .ToListAsync();
        }

        virtual public async Task<List<T>> GetAllOrderedAsync(Expression<Func<T, bool>> where, Expression<Func<T, object>> order, bool descending = true, bool tracking = false)
        {
            if (descending)
            {
                if (tracking)
                    return await _context.Set<T>()
                        .Where(where)
                        .OrderByDescending(order)
                        .ToListAsync();
                else
                    return await _context.Set<T>()
                        .AsNoTracking()
                        .Where(where)
                        .OrderByDescending(order)
                        .ToListAsync();
            }
            else
            {
                if (tracking)
                    return await _context.Set<T>()
                        .Where(where)
                        .OrderBy(order)
                        .ToListAsync();
                else
                    return await _context.Set<T>()
                        .AsNoTracking()
                        .Where(where)
                        .OrderBy(order)
                        .ToListAsync();
            }

        }

        virtual public async Task<T> GetByIdAsync(int id)
        {
            return await _context.FindAsync<T>(id);
        }

        virtual public async Task<bool> RemoveAsync(int id)
        {
            T entity = await _context.Set<T>().FindAsync(id);
            _context.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        virtual public async Task<bool> RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        virtual public async Task<bool> RemoveRangeAsync(List<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            return await _context.SaveChangesAsync() > 0;
        }

        virtual public async Task<bool> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        virtual public async Task<bool> ReSeedTable(string tablename)
        {
            _context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT('{tablename}', RESEED, 0)");
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

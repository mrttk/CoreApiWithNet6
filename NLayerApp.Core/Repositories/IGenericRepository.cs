﻿using System.Linq.Expressions;

namespace NLayerApp.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(int id);
        // productRepository.where(x=>x.id > 5).ToListAsync();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);
    }
}
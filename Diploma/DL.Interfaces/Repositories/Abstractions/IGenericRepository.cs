﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DL.Entities.Base;

namespace DL.Interfaces.Repositories.Abstractions
{
    public interface IGenericRepository<TEntity> where TEntity : class, IBaseEntity
    {
        Task<TEntity> GetByIdAsync(long id);

        Task<IEnumerable<TEntity>> SelectAsync();

        Task<IEnumerable<TEntity>> SelectAsync(params Expression<Func<TEntity, object>>[] includes);

        Task<IEnumerable<TEntity>> SelectAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        Task AddAsync(TEntity entity);

        Task AddRangeAsync(IEnumerable<TEntity> entities);

        TEntity Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        TEntity Update(TEntity entity);

        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includes);

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);
    } 
}

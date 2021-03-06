﻿//using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using JieDDDFramework.Core.Domain;

namespace JieDDDFramework.Data.Repository
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity :  Entity, new()
    {
        void Insert(TEntity entity);
        
        void Insert(params TEntity[] entities);

        void Insert(IEnumerable<TEntity> entities);
        
        Task InsertAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

        Task InsertAsync(params TEntity[] entities);

        Task InsertAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(TEntity entity);

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Update(params TEntity[] entities);

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Update(IEnumerable<TEntity> entities);

        /// <summary>
        /// Deletes the entity by the specified primary key.
        /// </summary>
        /// <param name="id">The primary key value.</param>
        void Delete(object id);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Delete(params TEntity[] entities);

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Delete(IEnumerable<TEntity> entities);

        TEntity FindEntity(object keyValue);

        TEntity FindEntity(Expression<Func<TEntity, bool>> criterion);

        Task<TEntity> FindEntityAsync(object keyValue);

        Task<TEntity> FindEntityAsync(Expression<Func<TEntity, bool>> criterion);

        IQueryable<TEntity> Tables();

        IQueryable<TEntity> Tables(Expression<Func<TEntity, bool>> criterion);

    }
}

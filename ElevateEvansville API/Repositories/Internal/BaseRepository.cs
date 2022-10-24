using ElevateEvansville_API.Enums;
using ElevateEvansville_API.Repositories.Interfaces;

namespace ElevateEvansville_API.Repositories.Internal
{

    /// <summary>
    /// Repository implementation for <typeparamref name="TEntity"/> using Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseRepository<TEntity>
        : BaseReadOnlyRepository<TEntity>, IRepository<TEntity>
        where TEntity : class
    {

        public DeletionType DeletionType => DeletionType.Permanent;

        /// <summary>
        /// Initializes a new repository.
        /// </summary>
        /// <param name="context"></param>
        protected BaseRepository(DatabaseContext context) : base(context) { }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);

            Context.Set<TEntity>().Add(entity);
            await Context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entities);

            Context.Set<TEntity>().AddRange(entities);
            await Context.SaveChangesAsync(cancellationToken);
            return entities;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);

            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entities);

            Context.Set<TEntity>().RemoveRange(entities);
            await Context.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await Context.SaveChangesAsync(cancellationToken);
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entity);

            Context.Set<TEntity>().Update(entity);
            await Context.SaveChangesAsync(cancellationToken);
            return entity;
        }

        /// <inheritdoc/>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default)
        {
            ArgumentNullException.ThrowIfNull(entities);

            Context.Set<TEntity>().UpdateRange(entities);
            await Context.SaveChangesAsync(cancellationToken);
            return entities;
        }
    }
}

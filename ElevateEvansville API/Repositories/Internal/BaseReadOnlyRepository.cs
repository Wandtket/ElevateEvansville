using ElevateEvansville_API.Extensions.Sorting;
using ElevateEvansville_API.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ElevateEvansville_API.Repositories.Internal
{
    /// <summary>
    /// Read only repository implemetation for <typeparamref name="TEntity"/> using Entity Framework.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public abstract class BaseReadOnlyRepository<TEntity>
        : IReadOnlyRepository<TEntity>, IDisposable
        where TEntity : class
    {

        /// <summary>
        /// The context associated with the repository.
        /// </summary>
        protected DatabaseContext Context { get; private set; }

        /// <summary>
        /// Initializes a new repository.
        /// </summary>
        /// <param name="context"></param>
        protected BaseReadOnlyRepository(DatabaseContext context)
        {
            Context = context;
        }

        public virtual async Task<bool> AnyAsync()
        {
            return await Context.Set<TEntity>().AnyAsync();
        }

        public virtual async Task<int> CountAsync()
        {
            return await Context.Set<TEntity>().CountAsync();
        }

        public virtual async Task<TEntity?> GetAsync<TId>(TId id)
        {
            return await FindAsync(id);
        }

        public virtual async Task<TEntity?> FindAsync<TId>(TId id)
        {
            return await Context.Set<TEntity>().FindAsync(id);
        }

        public virtual IEnumerable<TEntity> SkipWhile(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().SkipWhile(predicate);
        }

        public virtual IEnumerable<TEntity> TakeWhile(Func<TEntity, bool> predicate)
        {
            return Context.Set<TEntity>().TakeWhile(predicate);
        }

        public async virtual Task<IEnumerable<TEntity>> ListAsync(
            int skip = 0,
            int? limit = null,
            string[]? includes = null,
            string? sort = null,
            CancellationToken cancellationToken = default)
        {
            IQueryable<TEntity> query = Context.Set<TEntity>();

            if (skip > 0)
            {
                query = query.Skip(skip);
            }

            if (limit != null)
            {
                query = query.Take((int)limit);
            }

            if (includes != null)
            {
                foreach (string include in includes)
                {
                    query = query.Include(include);
                }
            }

            if (!string.IsNullOrEmpty(sort))
            {
                query = query.Sort(sort);
            }

            return await query.ToListAsync(cancellationToken);
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return Context.Set<TEntity>().AsQueryable();
        }

        public bool Contains(TEntity entity)
        {
            return Context.Set<TEntity>().Contains(entity);
        }

        public bool Contains(Expression<Func<TEntity, bool>> predicate)
        {
            var items = Context.Set<TEntity>().Where(predicate).AsNoTracking().ToList();
            return items.Count > 0;
        }

        public async Task<TEntity?> FirstOrDefaultAsync(CancellationToken cancellationToken = default)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await Context.Set<TEntity>().FirstOrDefaultAsync(predicate, cancellationToken);
        }

        public async Task LoadReference<TValue>(TEntity entity, Expression<Func<TEntity, TValue?>> selector) where TValue : class
        {
            await Context.Entry(entity).Reference(selector).LoadAsync();
        }

        public async Task LoadCollection<TValue>(TEntity entity, Expression<Func<TEntity, IEnumerable<TValue>>> selector) where TValue : class
        {
            await Context.Entry(entity).Collection(selector).LoadAsync();
        }

        /// <inheritdoc />
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}

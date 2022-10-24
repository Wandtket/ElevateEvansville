using System.Linq.Expressions;

namespace ElevateEvansville_API.Repositories.Interfaces
{
    /// <summary>
    /// Read only repository for <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IReadOnlyRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Gets the entity with the primary key of <paramref name="id"/>.
        /// </summary>
        /// <typeparam name="TId"></typeparam>
        /// <param name="id"></param>
        /// <returns>The entity with the specified id.</returns>
        Task<TEntity?> GetAsync<TId>(TId id);

        /// <summary>
        /// Finds the entity with the primary key of <paramref name="id"/>.
        /// </summary>
        /// <typeparam name="TId"></typeparam>
        /// <param name="id"></param>
        /// <returns>The entity with the specified id.</returns>
        Task<TEntity?> FindAsync<TId>(TId id);

        /// <summary>
        /// Retreives all records in the tables based on parameters passed to it.
        /// </summary>
        /// <param name="skip"></param>
        /// <param name="limit"></param>
        /// <param name="includes"></param>
        /// <param name="sort"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> ListAsync(
            int skip = 0,
            int? limit = null,
            string[]? includes = null,
            string? sort = null,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the number of records in the table.
        /// </summary>
        /// <returns>The number of entities in the table.</returns>
        Task<int> CountAsync();

        /// <summary>
        /// Checks if there are any records in the table.
        /// </summary>
        /// <returns>Whether any entities exist in the table.</returns>
        Task<bool> AnyAsync();

        /// <summary>
        /// Returns a query object for dynamic query creation.
        /// </summary>
        /// <returns></returns>
        IQueryable<TEntity> AsQueryable();

        /// <summary>
        ///
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>A list of entities that result in a true return value for the <paramref name="predicate"/>.</returns>
        IEnumerable<TEntity> TakeWhile(Func<TEntity, bool> predicate);

        /// <summary>
        ///
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>A list of entities that result in a false return value for the <paramref name="predicate"/>.</returns>
        IEnumerable<TEntity> SkipWhile(Func<TEntity, bool> predicate);

        /// <summary>
        /// Checks if the an entity matching <paramref name="entity"/> is in the table.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns>Whether a match is found.</returns>
        bool Contains(TEntity entity);

        /// <summary>
        /// Checks if there is an entity matching the <paramref name="predicate"/> passed to function.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns>Whether a match is found.</returns>
        bool Contains(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Gets the first entity in the table, if one is not found returns null.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>The first entity or null.</returns>
        Task<TEntity?> FirstOrDefaultAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the first element matching the <paramref name="predicate"/>.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The first entity or null.</returns>
        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Loads a reference associated with the <paramref name="entity"/>.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="entity"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task LoadReference<TValue>(TEntity entity, Expression<Func<TEntity, TValue?>> selector) where TValue : class;

        /// <summary>
        /// Loads a collection associated with the <paramref name="entity"/>.
        /// </summary>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="entity"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        Task LoadCollection<TValue>(TEntity entity, Expression<Func<TEntity, IEnumerable<TValue>>> selector) where TValue : class;

    }
}

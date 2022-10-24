namespace ElevateEvansville_API.Repositories.Interfaces
{

    /// <summary>
    /// Repository for <typeparamref name="TEntity"/>.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
        : IReadOnlyRepository<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Creates a new record in the table.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The created entity.</returns>
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new record for each item in <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The list of entities that have been created.</returns>
        Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the record in the table.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>The updated entity.</returns>
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the record that corresponds to each item in <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns>A list of entities that were updated.</returns>
        Task<IEnumerable<TEntity>> UpdateRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        /// <summary>
        /// Permenantly deletes the record from the table.
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="cancellationToken"></param>
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Permenantly deletes the record that corresponds to each item in <paramref name="entities"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        Task DeleteRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);

        /// <summary>
        /// Saves changes in the database.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>The number of changes that have been committed.</returns>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}

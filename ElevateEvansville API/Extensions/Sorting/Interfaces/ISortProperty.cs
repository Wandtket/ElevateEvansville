namespace ElevateEvansville_API.Extensions.Sorting.Interfaces
{
    public interface ISortProperty<TEntity>
    {
        /// <summary>
        /// Applies the sort for the property to <paramref name="query"/>.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>The <paramref name="query"/> with the sort applied.</returns>
        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
    }
}

namespace ElevateEvansville_API.Extensions.Sorting
{
    public static class IQueryableExtensions
    {
        /// <summary>
        /// Sorts the <seealso cref="IQueryable{T}"/> based on the sort string passed to it.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="query"></param>
        /// <param name="sorts"></param>
        /// <returns>A sorted <seealso cref="IQueryable{T}"/>.</returns>
        public static IQueryable<TEntity> Sort<TEntity>(this IQueryable<TEntity> query, string? sorts)
        {
            if (string.IsNullOrEmpty(sorts))
            {
                return query;
            }

            SortCollection<TEntity> collection = new SortCollection<TEntity>(sorts);
            query = collection.Apply(query);
            return query;
        }
    }
}

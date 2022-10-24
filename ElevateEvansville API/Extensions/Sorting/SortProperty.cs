using ElevateEvansville_API.Extensions.Sorting.Interfaces;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace ElevateEvansville_API.Extensions.Sorting
{
    public class SortProperty<TEntity, TField> : ISortProperty<TEntity>
    {
        /// <summary>
        /// The property this sort is associated with.
        /// </summary>
        public string Property { get; private set; }

        /// <summary>
        /// The direction the porperty will be ordered by.
        /// </summary>
        public ListSortDirection Direction { get; private set; }

        public Expression<Func<TEntity, TField>> Filter { get; private set; }

        /// <summary>
        /// Initializes a new <seealso cref="SortProperty{TEntity, TField}"/>.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="direction"></param>
        public SortProperty(PropertyInfo property, ListSortDirection direction)
        {
            Property = property.Name;
            Direction = direction;

            var source = Expression.Parameter(typeof(TEntity), "x");
            var member = Expression.Property(source, property);
            Filter = Expression.Lambda<Func<TEntity, TField>>(member, source);
        }

        /// <inheritdoc />
        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
        {
            OrderMethodFinder finder = new OrderMethodFinder();
            finder.Visit(query.Expression);

            if (finder.OrderByFound)
            {
                query = Direction == ListSortDirection.Ascending
                    ? ((IOrderedQueryable<TEntity>)query).ThenBy(Filter)
                    : ((IOrderedQueryable<TEntity>)query).ThenByDescending(Filter);
            }
            else
            {
                query = Direction == ListSortDirection.Ascending
                    ? query.OrderBy(Filter)
                    : query.OrderByDescending(Filter);
            }

            return query;
        }

        public override string ToString()
        {
            if (Direction == ListSortDirection.Descending)
            {
                return $"-{Property}";
            }

            return Property;
        }
    }

}

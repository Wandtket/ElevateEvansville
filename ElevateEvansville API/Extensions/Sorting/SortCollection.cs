using ElevateEvansville_API.Extensions.Sorting.Interfaces;
using System.ComponentModel;
using System.Reflection;

namespace ElevateEvansville_API.Extensions.Sorting
{
    public class SortCollection<TEntity>
    {
        private List<ISortProperty<TEntity>> _properties = new();

        /// <summary>
        /// The properties and how they will be sorted.
        /// </summary>
        public IEnumerable<ISortProperty<TEntity>> Properties => _properties.AsEnumerable();

        /// <summary>
        /// Initalizes a new <seealso cref="SortCollection{TEntity}"/> by parsing the <paramref name="sorts"/> parameter.
        /// </summary>
        /// <param name="sorts"></param>
        public SortCollection(string sorts) : this(sorts.Split(',', StringSplitOptions.RemoveEmptyEntries)) { }

        /// <summary>
        /// Initializes a new <seealso cref="SortCollection{TEntity}"/> by parsing the each sort in <paramref name="sorts"/>.
        /// </summary>
        /// <param name="sorts"></param>
        public SortCollection(string[] sorts)
        {
            foreach (var s in sorts)
            {
                var property = Parse(s);
                if (property == null)
                {
                    continue;
                }

                _properties.Add(property);
            }
        }

        private ISortProperty<TEntity>? Parse(string property)
        {
            ListSortDirection direction = ListSortDirection.Ascending;
            if (property.StartsWith('-'))
            {
                direction = ListSortDirection.Descending;
            }

            string propertyName = property;
            if (property.StartsWith('+') || property.StartsWith('-'))
            {
                propertyName = property[1..];
            }

            var properties = typeof(TEntity).GetProperties();
            var prop = properties.Where(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase)).SingleOrDefault();
            if (prop == null)
            {
                return null;
            }

            ConstructorInfo? ctor =
                typeof(SortProperty<,>)
                .MakeGenericType(typeof(TEntity), prop.PropertyType)
                .GetConstructor(new[] { typeof(PropertyInfo), typeof(ListSortDirection) });
            if (ctor == null)
            {
                throw new MethodAccessException($"Unable to find constructor for SortProperty.");
            }

            object instance = ctor.Invoke(new object[] { prop, direction });
            return (ISortProperty<TEntity>)instance;
        }

        /// <summary>
        /// Applies all <seealso cref="Properties"/> to the <paramref name="query"/>.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>The <paramref name="query"/> with all sorts applied.</returns>
        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
        {
            foreach (var property in Properties)
            {
                query = property.Apply(query);
            }

            return query;
        }

        public override string ToString()
        {
            return string.Join(",", Properties);
        }
    }

}

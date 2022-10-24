using Ardalis.SmartEnum;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace ElevateEvansville_API.Extensions.Filtering
{
    enum FilterType
    {
        Equal,
        NotEqual,
        GreaterThan,
        GreaterThanEqual,
        LessThan,
        LessThanEqual,
    }

    public static class IQueryableExtensions
    {
        /// <summary>
        /// Filters the <seealso cref="IQueryable{T}"/> based on the <paramref name="propertyName"/> and <paramref name="filter"/> passed.
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TField"></typeparam>
        /// <param name="query"></param>
        /// <param name="propertyName"></param>
        /// <param name="filter"></param>
        /// <returns>An <seealso cref="IQueryable{T}"/> with a filter appended to it.</returns>
        public static IQueryable<TEntity> Filter<TEntity, TField>(this IQueryable<TEntity> query, string propertyName, TField? filter)
        {
            ArgumentNullException.ThrowIfNull(propertyName);

            if (filter == null)
            {
                return query;
            }

            var properties = typeof(TEntity).GetProperties();
            var property = properties.Where(p => p.Name.Equals(propertyName, StringComparison.OrdinalIgnoreCase)).SingleOrDefault();
            if (property == null) // invalid property found, return the original query
            {
                return query;
            }

            string? filterValue = filter.ToString();
            if (string.IsNullOrEmpty(filterValue))
            {
                return query;
            }

            FilterType type = FilterType.Equal;
            if (filterValue.Contains(':'))
            {
                var splits = filterValue.Split(':', StringSplitOptions.RemoveEmptyEntries);

                switch (splits[0])
                {
                    case "e":
                        type = FilterType.Equal;
                        break;
                    case "ne":
                        type = FilterType.NotEqual;
                        break;
                    case "lt":
                        type = FilterType.LessThan;
                        break;
                    case "lte":
                        type = FilterType.LessThanEqual;
                        break;
                    case "gt":
                        type = FilterType.GreaterThan;
                        break;
                    case "gte":
                        type = FilterType.GreaterThanEqual;
                        break;
                }

                filterValue = splits[1];
            }

            var source = Expression.Parameter(typeof(TEntity), "x");
            var member = Expression.Property(source, property);

            Expression filterValueExpression = Expression.Constant(filterValue);

            Type propertyType = property.PropertyType;
            if (propertyType.IsGenericType)
            {
                if (propertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    filterValueExpression = Expression.Convert(Expression.Constant(filter), propertyType);
                }
            }
            else if (propertyType.IsSmartEnum())
            {
                var method = propertyType.GetMethod("FromName", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)!;
                var result = method.Invoke(null, new object[] { filter, true });
                filterValueExpression = Expression.Convert(Expression.Constant(result), propertyType);
            }
            else if (propertyType.IsPrimitive)
            {
                var converter = TypeDescriptor.GetConverter(propertyType);
                filterValueExpression = Expression.Constant(converter.ConvertFromInvariantString(filterValue));
            }

            Expression? comparisonExpression = null;
            switch (type)
            {
                case FilterType.Equal:
                    comparisonExpression = Expression.Equal(member, filterValueExpression);
                    break;
                case FilterType.NotEqual:
                    comparisonExpression = Expression.NotEqual(member, filterValueExpression);
                    break;
                case FilterType.LessThan:
                    comparisonExpression = Expression.LessThan(member, filterValueExpression);
                    break;
                case FilterType.LessThanEqual:
                    comparisonExpression = Expression.LessThanOrEqual(member, filterValueExpression);
                    break;
                case FilterType.GreaterThan:
                    comparisonExpression = Expression.GreaterThan(member, filterValueExpression);
                    break;
                case FilterType.GreaterThanEqual:
                    comparisonExpression = Expression.GreaterThanOrEqual(member, filterValueExpression);
                    break;
            }

            if (comparisonExpression == null)
            {
                return query;
            }

            var filterExpression = Expression.Lambda<Func<TEntity, bool>>(comparisonExpression, source);
            query = query.Where(filterExpression);

            return query;
        }
    }
}

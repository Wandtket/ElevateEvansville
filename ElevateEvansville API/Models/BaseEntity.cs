using ElevateEvansville_API.Interfaces.Models;

namespace ElevateEvansville_API.Models
{
    public class BaseEntity<TKey> : IEntity<TKey>, IEquatable<BaseEntity<TKey>> where TKey : notnull
    {

        /// <summary>
        /// The primary key for the entity.
        /// </summary>
        public TKey Id { get; set; }


        /// <inheritdoc />
        public bool Equals(BaseEntity<TKey>? other)
        {
            if (other == null)
            {
                return false;
            }

            return Id.Equals(other.Id);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <inheritdoc />
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj is BaseEntity<TKey> entity)
            {
                return Equals(entity);
            }

            return base.Equals(obj);
        }

        /// <summary>
        /// Check if the id is the default value for the key type.
        /// </summary>
        /// <remarks>
        /// This function can be used to determine if the record has been created already.
        /// </remarks>
        /// <returns>Whether the value of Id is the default value.</returns>
        public bool IsTransient()
        {
            return Id.Equals(default(TKey));
        }

        protected BaseEntity() { }
    }
}

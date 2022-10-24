namespace ElevateEvansville_API.Interfaces.Models
{
    /// <summary>
    /// Interface for all entities to inherit from.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// The primary key of the entity.
        /// </summary>
        TKey Id { get; set; }
    }
}

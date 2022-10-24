namespace ElevateEvansville_API.Interfaces.Models
{
    /// <summary>
    /// Interface for keeping track of when an entity was created and who created it.
    /// </summary>
    public interface ICreationTrackable
    {
        /// <summary>
        /// When the entity was created.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Who created the entity.
        /// </summary>
        public int UserId { get; set; }
    }
}

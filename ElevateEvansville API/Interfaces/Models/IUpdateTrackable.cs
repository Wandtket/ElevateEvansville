namespace ElevateEvansville_API.Interfaces.Models
{
    /// <summary>
    /// Interface for keeping track of when an entity was updated and who updated it.
    /// </summary>
    public interface IUpdateTrackable
    {
        /// <summary>
        /// When the entity was last updated.
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Who last updated the entity.
        /// </summary>
        public int? UpdateUserId { get; set; }
    }
}

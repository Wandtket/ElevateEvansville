namespace ElevateEvansville_API.Interfaces.Models
{
    /// <summary>
    /// Interface for entities who keep track of when they were created/last updated and by who.
    /// </summary>
    /// <remarks>
    /// This enables us to have entity framework automatically set the date an entity was created/updated and who performed that action.
    /// </remarks>
    public interface ITrackableEntity : ICreationTrackable, IUpdateTrackable { }
}

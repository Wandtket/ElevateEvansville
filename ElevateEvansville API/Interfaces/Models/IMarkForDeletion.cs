namespace ElevateEvansville_API.Interfaces.Models
{
    /// <summary>
    /// Signifies that the entity should not be permanently deleted,
    /// but instead will be marked for deletion.
    /// </summary>
    public interface IMarkForDeletion
    {
        public bool Deleted { get; set; }
    }
}

namespace PartlyRebuildIdentity.Models.Interfaces
{
    public interface IModel<out T> : IOutCovariant<T>
    {
        T Id { get; }
    }
}
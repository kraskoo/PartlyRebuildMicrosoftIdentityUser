namespace PartlyRebuildIdentity.Data.Intefaces
{
    public interface ITweeterRepository<T> : IRepository<T>
        where T : class, new()
    {
    }
}
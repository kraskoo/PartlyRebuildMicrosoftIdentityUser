namespace PartlyRebuildIdentity.Models.Interfaces
{
    public interface IIdentityUserRole<out TKey> : IOutCovariant<TKey>
    {
        TKey UserId { get; }

        TKey RoleId { get; }
    }
}
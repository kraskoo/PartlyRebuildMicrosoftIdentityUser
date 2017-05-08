namespace PartlyRebuildIdentity.Models.Interfaces
{
    public interface IRoleIdentity<out TKey, TUserRole> : IModel<TKey>
        where TUserRole : IIdentityUserRole<TKey>
    {
    }
}
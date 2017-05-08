namespace PartlyRebuildIdentity.Data.Intefaces.IdentityStores
{
    using Microsoft.AspNet.Identity;
    using Models.Interfaces;

    public interface IQueryableIdentityStore<TUser, in TKey> :
        IIdentityStore<TUser, TKey>,
        IQueryableUserStore<TUser, TKey>
        where TUser : class, IIdentityApplicationUser<TKey>, IUser<TKey>
    {
    }
}
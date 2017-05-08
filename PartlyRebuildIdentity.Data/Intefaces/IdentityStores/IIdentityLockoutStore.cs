namespace PartlyRebuildIdentity.Data.Intefaces.IdentityStores
{
    using Microsoft.AspNet.Identity;
    using Models.Interfaces;

    public interface IIdentityLockoutStore<TUser, in TKey> :
        IIdentityStore<TUser, TKey>,
        IUserLockoutStore<TUser, TKey>
        where TUser : class, IIdentityApplicationUser<TKey>, IUser<TKey>
    {
    }
}
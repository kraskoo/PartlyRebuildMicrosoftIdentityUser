namespace PartlyRebuildIdentity.Data.Intefaces.IdentityStores
{
    using Microsoft.AspNet.Identity;
    using Models.Interfaces;

    public interface IIdentityPasswordStore<TUser, in TKey> :
        IIdentityStore<TUser, TKey>,
        IUserPasswordStore<TUser, TKey>
        where TUser : class, IIdentityApplicationUser<TKey>, IUser<TKey>
    {
    }
}
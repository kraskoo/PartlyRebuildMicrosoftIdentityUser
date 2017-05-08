namespace PartlyRebuildIdentity.Data.Intefaces.IdentityStores
{
    using Microsoft.AspNet.Identity;
    using Models.Interfaces;

    public interface IIdentityRoleStore<TUser, in TKey> :
        IIdentityStore<TUser, TKey>,
        IUserRoleStore<TUser, TKey>
        where TUser : class, IIdentityApplicationUser<TKey>, IUser<TKey>
    {
    }
}
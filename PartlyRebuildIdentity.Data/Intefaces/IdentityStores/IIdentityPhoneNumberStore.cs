namespace PartlyRebuildIdentity.Data.Intefaces.IdentityStores
{
    using Microsoft.AspNet.Identity;
    using Models.Interfaces;

    public interface IIdentityPhoneNumberStore<TUser, in TKey> :
        IIdentityStore<TUser, TKey>,
        IUserPhoneNumberStore<TUser, TKey>
        where TUser : class, IIdentityApplicationUser<TKey>, IUser<TKey>
    {
    }
}
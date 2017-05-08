namespace PartlyRebuildIdentity.Data.Intefaces
{
    using Microsoft.AspNet.Identity;

    public interface IIdentityUserStore<TUser, in TKey> : IUserStore<TUser, TKey>
        where TUser : class, IUser<TKey>
    {
    }
}
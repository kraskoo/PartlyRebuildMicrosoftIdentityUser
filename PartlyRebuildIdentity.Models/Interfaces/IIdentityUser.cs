namespace PartlyRebuildIdentity.Models.Interfaces
{
    public interface IIdentityUser<out TKey, TLogin, TRole, TClaim>
        where TLogin : ILogin<TKey>
        where TRole : IRole<TKey>
        where TClaim : IClaim<TKey>
    {
    }
}
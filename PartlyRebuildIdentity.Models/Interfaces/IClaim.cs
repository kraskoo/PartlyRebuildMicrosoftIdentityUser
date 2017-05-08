namespace PartlyRebuildIdentity.Models.Interfaces
{
    public interface IClaim<TUser> : IInCovariant<TUser>
    {
        TUser UserId { get; }
    }
}
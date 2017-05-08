namespace PartlyRebuildIdentity.Data.Intefaces
{
    using Models.Identity;

    public interface IUserRepository : IRepository<IdentityApplicationUser<string>>
    {
    }
}
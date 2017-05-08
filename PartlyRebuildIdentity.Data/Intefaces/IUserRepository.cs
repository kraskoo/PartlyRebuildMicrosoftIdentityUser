namespace PartlyRebuildIdentity.Data.Intefaces
{
    using Models.Idenity;

    public interface IUserRepository : IRepository<IdentityApplicationUser<string>>
    {
    }
}
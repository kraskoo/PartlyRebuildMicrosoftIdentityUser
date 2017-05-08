namespace PartlyRebuildIdentity.Data.Intefaces.CrudOperations.Identity
{
    using Microsoft.AspNet.Identity;

    public interface IIdentityRole
    {
        IdentityResult AddToRole();
    }
}
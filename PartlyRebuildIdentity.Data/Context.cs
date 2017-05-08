namespace PartlyRebuildIdentity.Data
{
    using System;
    using Microsoft.AspNet.Identity.EntityFramework;
    using DataModels;

    public class Context : IdentityDbContext<
        ApplicationUser,
        ApplicationRole,
        Guid,
        ApplicationLogin,
        ApplicationUserRole,
        ApplicationClaim>
    {
    }
}
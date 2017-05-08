namespace PartlyRebuildIdentity.Data.DataModels
{
    using System;
    using Models.Identity;

    public class ApplicationRole : IdentityRoleInner<Guid, ApplicationUserRole>
    {
    }
}
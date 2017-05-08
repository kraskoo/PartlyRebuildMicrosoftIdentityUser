namespace PartlyRebuildIdentity.Data.DataModels
{
    using System;
    using Models.Idenity;

    public class ApplicationRole : IdentityRoleInner<Guid, ApplicationUserRole>
    {
    }
}
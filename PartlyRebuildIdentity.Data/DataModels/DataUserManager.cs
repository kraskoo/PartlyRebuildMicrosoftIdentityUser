namespace PartlyRebuildIdentity.Data.DataModels
{
    using System;
    using Microsoft.AspNet.Identity;
    using Identity;

    public class DataUserManager : UserManager<ApplicationUser, Guid>
    {
        public DataUserManager(IdentityStore store) : base(store)
        {
        }
    }
}
namespace PartlyRebuildIdentity.Data.DataModels.Identity
{
    using System;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin.Security.DataProtection;

    public class DataProtectorTokenProvider : DataProtectorTokenProvider<ApplicationUser, Guid>, IUserTokenProvider<ApplicationUser, Guid>
    {
        public DataProtectorTokenProvider(IDataProtector protector) : base(protector)
        {
        }
    }
}
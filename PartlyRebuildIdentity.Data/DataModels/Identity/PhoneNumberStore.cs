namespace PartlyRebuildIdentity.Data.DataModels.Identity
{
    using System;
    using Microsoft.AspNet.Identity;

    public class PhoneNumberStore : PhoneNumberTokenProvider<ApplicationUser, Guid>
    {
    }
}
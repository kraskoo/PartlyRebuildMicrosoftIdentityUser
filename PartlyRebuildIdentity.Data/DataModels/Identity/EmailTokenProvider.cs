namespace PartlyRebuildIdentity.Data.DataModels.Identity
{
    using System;
    using Microsoft.AspNet.Identity;

    public class EmailTokenProvider : EmailTokenProvider<ApplicationUser, Guid>
    {
    }
}
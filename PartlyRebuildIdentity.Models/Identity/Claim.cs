namespace PartlyRebuildIdentity.Models.Identity
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Interfaces;

    public class Claim<TUser> : IdentityUserClaim<TUser>, IModel<int>, IClaim<TUser>
    {
        public override int Id { get; set; }

        public override TUser UserId { get; set; }
    }
}
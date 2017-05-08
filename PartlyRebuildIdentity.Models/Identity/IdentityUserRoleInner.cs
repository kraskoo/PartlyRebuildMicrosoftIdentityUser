namespace PartlyRebuildIdentity.Models.Identity
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Interfaces;

    public class IdentityUserRoleInner<TKey> : IdentityUserRole<TKey>, IIdentityUserRole<TKey>
    {
        public override TKey UserId { get; set; }

        public override TKey RoleId { get; set; }
    }
}
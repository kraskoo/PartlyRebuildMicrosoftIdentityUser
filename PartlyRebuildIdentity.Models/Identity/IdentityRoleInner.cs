namespace PartlyRebuildIdentity.Models.Identity
{
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Interfaces;

    public class IdentityRoleInner<TKey, TUserRole> :
        IdentityRole<TKey, TUserRole>,
        IRoleIdentity<TKey, TUserRole>,
        IRole<TKey>
        where TUserRole : IdentityUserRole<TKey>, IIdentityUserRole<TKey>
    {
        public IdentityRoleInner(ICollection<TUserRole> users)
        {
            this.Users = users;
        }

        public IdentityRoleInner() : this(
            new HashSet<TUserRole>())
        {
        }

        public new TKey Id { get; set; }

        public override ICollection<TUserRole> Users { get; }
    }
}
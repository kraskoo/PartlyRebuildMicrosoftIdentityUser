namespace PartlyRebuildIdentity.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Idenity;

    public class ApplicationUserIdentity<TKey> :
        IdentityUser<TKey, Login<TKey>, IdentityUserRoleInner<TKey>, Claim<TKey>>
    {
    }
}
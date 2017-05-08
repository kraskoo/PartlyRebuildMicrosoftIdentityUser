namespace PartlyRebuildIdentity.Models.Idenity
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Interfaces;

    public class IdentityApplicationUser<TKey> :
        IdentityUserRole<TKey>,
        IIdentityApplicationUser<TKey>,
        IUser<TKey>
    {
        public virtual TKey Id { get; set; }

        public virtual string UserName { get; set; }
    }
}
namespace PartlyRebuildIdentity.Models.Idenity
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Interfaces;

    public class Login<T> : IdentityUserLogin<T>, ILogin<T>
    {
        public T Id { get; set; }
    }
}
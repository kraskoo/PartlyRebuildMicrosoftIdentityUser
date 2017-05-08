namespace PartlyRebuildIdentity.Models.Idenity
{
    using Interfaces;
    using MSAspId = Microsoft.AspNet.Identity;

    public class Role<TKey> : IRole<TKey>, MSAspId.IRole<TKey>
    {
        public TKey Id { get; set; }

        public string Name { get; set; }
    }
}
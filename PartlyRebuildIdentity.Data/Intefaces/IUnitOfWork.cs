namespace PartlyRebuildIdentity.Data.Intefaces
{
    using System.Threading.Tasks;
    using Enums;

    public interface IUnitOfWork<T>
        where T : IContextFactory<Context>
    {
        void ChangeState<TEntity>(TEntity entity, State state)
            where TEntity : class, new();

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
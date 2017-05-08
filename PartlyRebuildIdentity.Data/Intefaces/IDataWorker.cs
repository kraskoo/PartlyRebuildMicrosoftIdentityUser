namespace PartlyRebuildIdentity.Data.Intefaces
{
    using System.Data.Entity;
    using System.Threading.Tasks;

    public interface IDataWorker
    {
        int SaveChanges();

        Task<int> SaveChangesAsync();

        void ChangeState<TEntity>(TEntity entity, EntityState newState)
            where TEntity : class, new();
    }
}
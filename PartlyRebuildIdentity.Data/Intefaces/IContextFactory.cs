namespace PartlyRebuildIdentity.Data.Intefaces
{
    using System;
    using System.Data.Entity;

    public interface IContextFactory<out T> : IDisposable, IDataWorker
        where T : DbContext
    {
        IDbSet<TEntity> Set<TEntity>()
            where TEntity : class, new();
    }
}
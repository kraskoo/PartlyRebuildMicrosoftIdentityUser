namespace PartlyRebuildIdentity.Data.DataModels
{
    using System;
    using System.Collections.Concurrent;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using Intefaces;

    public abstract class ContextFactory<T> : IContextFactory<T>
        where T : DbContext
    {
        private readonly IDictionary<Type, object> setByType;
        private bool isDisposed;

        protected ContextFactory(T context)
        {
            this.Context = context;
            this.setByType = new ConcurrentDictionary<Type, object>();
        }

        public T Context { get; protected set; }

        public void ChangeState<TEntity>(TEntity entity, EntityState newState)
            where TEntity : class, new()
        {
            this.Context.Entry(entity).State = newState;
        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : class, new()
        {
            var type = typeof(TEntity);
            if (!setByType.ContainsKey(type))
            {
                Expression<Func<T, IDbSet<TEntity>>> expr = t => Context.Set<TEntity>();
                var set = expr.Compile().Invoke(Context);
                this.setByType.Add(type, set);
            }

            return (IDbSet<TEntity>)this.setByType[type];
        }

        public void Dispose()
        {
            this.Disponse(true);
            GC.SuppressFinalize(this);
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.Context.SaveChangesAsync();
        }

        ~ContextFactory()
        {
            this.Disponse(false);
        }

        protected abstract void DisponseCore();

        private void Disponse(bool disponse)
        {
            if (!this.isDisposed && disponse)
            {
                this.isDisposed = true;
                this.DisponseCore();
            }
        }
    }
}
namespace PartlyRebuildIdentity.Data.DataModels
{
    using System;
    using System.Data.Entity;
    using System.Threading.Tasks;
    using Enums;
    using Intefaces;

    public abstract class UnitOfWork<T> : IUnitOfWork<T>
        where T : IContextFactory<Context>
    {
        protected UnitOfWork(IContextFactory<Context> context)
        {
            this.Context = context;
        }

        protected IContextFactory<Context> Context { get; }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.Context.SaveChangesAsync();
        }

        public void ChangeState<TEntity>(TEntity entity, State state)
            where TEntity : class, new()
        {
            this.Context.ChangeState(entity, this.GetOriginalState(state));
        }

        private EntityState GetOriginalState(State state)
        {
            switch (state)
            {
                case State.Added:
                    return EntityState.Added;
                case State.Deleted:
                    return EntityState.Deleted;
                case State.Detached:
                    return EntityState.Detached;
                case State.Modified:
                    return EntityState.Modified;
                case State.Unchanged:
                    return EntityState.Unchanged;
                default:
                    throw new ArgumentException("Unknown state.");
            }
        }
    }
}
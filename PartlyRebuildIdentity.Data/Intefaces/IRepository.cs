﻿namespace PartlyRebuildIdentity.Data.Intefaces
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    public interface IRepository<T> : ICrudAdapter<T>
        where T : class, new()
    {
        T Find(Expression<Func<T, bool>>[] wheres);

        Task<T> FindAsync(Expression<Func<T, bool>>[] wheres);

        IQueryable<T> FindAll(params Expression<Func<T, bool>>[] wheres);
    }
}
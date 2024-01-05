﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vculp.Api.Domain.Core.SharedKernel;

namespace Vculp.Api.Data.EntityFramework.Common
{
    public abstract class Repository<T> where T : Entity
    {
        public Repository(CoreContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            DbSet = context.Set<T>();

            Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        }

        protected DbSet<T> DbSet { get; }
        protected CoreContext Context { get; }

        public virtual T Find(Guid id)
        {
            if (id == Guid.Empty)
            {
                return null;
            }

            return DbSet.Find(id);
        }

        public async virtual Task<T> GetByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
            {
                return null;
            }

            var query = IncludeAll();
            return await query.SingleOrDefaultAsync(e => e.Id == id);
        }

        public virtual void Add(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            DbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            DbSet.Update(entity);
        }

        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }
            Context.Entry(entity).Property<bool>("IsDeleted").CurrentValue = true;
            var entityWithState = Context.Entry(entity).Entity as StatefulObject;

            entityWithState.GetType().GetProperty("State").SetValue(entityWithState, ObjectState.Deleted);
        }

        protected abstract IQueryable<T> IncludeAll();
    }
}

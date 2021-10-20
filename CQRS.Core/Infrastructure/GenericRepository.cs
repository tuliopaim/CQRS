﻿using System;
using System.Linq;
using CQRS.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Core.Infrastructure
{
    public abstract class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : Entity
    {
        private readonly EfDbContext _context;

        protected GenericRepository(EfDbContext context)
        {
            _context = context;
        }

        public IUnitOfWork UnitOfWork => _context;
                
        public IQueryable<TEntity> Get() => _context.Set<TEntity>().AsQueryable();

        public IQueryable<TEntity> GetAsNoTracking() => Get().AsNoTrackingWithIdentityResolution();

        public void Add(TEntity entity) => _context.Add(entity);

        public void Update(TEntity entity) => _context.Entry(entity).State = EntityState.Modified;

        public void Remove(Guid id) => _context.Remove(id);
    }
}
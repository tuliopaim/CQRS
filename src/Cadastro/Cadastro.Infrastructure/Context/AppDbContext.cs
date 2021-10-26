﻿using System.Reflection;
using CQRS.Core.API;
using CQRS.Core.Infrastructure;
using CQRS.Core.Infrastructure.Kafka;
using CQRS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Infrastructure.Context
{
    public class AppDbContext : EfDbContext
    {
        public AppDbContext(IEnvironment enviroment, IKafkaBroker kafkaBroker) : base(enviroment, kafkaBroker)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("CQRS");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
﻿using System.Reflection;
using CoreDesk.Server.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoreDesk.Server.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
         {
         }
         
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
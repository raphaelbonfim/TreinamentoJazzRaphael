﻿using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using TreinamentoJazzRaphael.EntityFramework;

namespace TreinamentoJazzRaphael.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<TreinamentoJazzRaphaelDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}

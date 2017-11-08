using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;

namespace TaiKang.EntityFramework
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<TaiKangDbContext, Migrations.Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver) :
            base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {

        }
    }
}

using System.Data.Entity.Migrations;
using Abp.Events.Bus;
using Abp.Events.Bus.Entities;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using EntityFramework.DynamicFilters;
using TaiKang.Migrations.Seed.Host;
using TaiKang.Migrations.Seed.Tenants;
using TaiKang.Migrations.Seed.Management;

namespace TaiKang.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<EntityFramework.TaiKangDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TaiKang";
        }

        protected override void Seed(EntityFramework.TaiKangDbContext context)
        {
            context.DisableAllFilters();

            context.EntityChangeEventHelper = NullEntityChangeEventHelper.Instance;
            context.EventBus = NullEventBus.Instance;

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantBuilder(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
                new DefaultCompanyIntroCreator(context).Create();
                new DefaultBannerCreator(context).Create();
            }
            else
            {
                //You can add seed for tenant databases using Tenant property...
            }

            context.SaveChanges();
        }
    }
}

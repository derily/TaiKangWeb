using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Castle.MicroKernel.Registration;
using TaiKang.EntityFramework;

namespace TaiKang.Migrator
{
    [DependsOn(typeof(TaiKangDataModule))]
    public class TaiKangMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TaiKangDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
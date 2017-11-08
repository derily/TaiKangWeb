using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using TaiKang.EntityFramework;

namespace TaiKang
{
    /// <summary>
    /// Entity framework module of the application.
    /// </summary>
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(TaiKangCoreModule))]
    public class TaiKangDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TaiKangDbContext>());

            //web.config (or app.config for non-web projects) file should contain a connection string named "Default".
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

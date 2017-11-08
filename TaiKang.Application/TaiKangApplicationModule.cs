using System.Reflection;
using Abp.AutoMapper;
using Abp.Localization;
using Abp.Modules;
using TaiKang.Authorization;

namespace TaiKang
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(typeof(TaiKangCoreModule))]
    public class TaiKangApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper mappings
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                CustomDtoMapper.CreateMappings(mapper);
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

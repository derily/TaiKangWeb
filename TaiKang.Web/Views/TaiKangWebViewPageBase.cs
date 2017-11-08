using Abp.Dependency;
using Abp.Runtime.Session;
using Abp.Web.Mvc.Views;

namespace TaiKang.Web.Views
{
    public abstract class TaiKangWebViewPageBase : TaiKangWebViewPageBase<dynamic>
    {
       
    }

    public abstract class TaiKangWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        public IAbpSession AbpSession { get; private set; }
        
        protected TaiKangWebViewPageBase()
        {
            AbpSession = IocManager.Instance.Resolve<IAbpSession>();
            LocalizationSourceName = TaiKangConsts.LocalizationSourceName;
        }
    }
}
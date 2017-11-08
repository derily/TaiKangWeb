using Abp.AutoMapper;
using TaiKang.MultiTenancy;
using TaiKang.MultiTenancy.Dto;
using TaiKang.Web.Areas.Mpa.Models.Common;

namespace TaiKang.Web.Areas.Mpa.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesForEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesForEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesForEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}
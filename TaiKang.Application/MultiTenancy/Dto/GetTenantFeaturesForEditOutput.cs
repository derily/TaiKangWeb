using System.Collections.Generic;
using Abp.Application.Services.Dto;
using TaiKang.Editions.Dto;

namespace TaiKang.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}
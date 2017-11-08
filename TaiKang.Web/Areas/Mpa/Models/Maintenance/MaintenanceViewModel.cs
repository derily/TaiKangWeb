using System.Collections.Generic;
using TaiKang.Caching.Dto;

namespace TaiKang.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}
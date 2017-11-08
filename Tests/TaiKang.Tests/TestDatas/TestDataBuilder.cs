using EntityFramework.DynamicFilters;
using TaiKang.EntityFramework;

namespace TaiKang.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly TaiKangDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(TaiKangDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}

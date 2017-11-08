using Xunit;

namespace TaiKang.Tests
{
    public sealed class MultiTenantTheoryAttribute : TheoryAttribute
    {
        public MultiTenantTheoryAttribute()
        {
            if (!TaiKangConsts.MultiTenancyEnabled)
            {
                Skip = "MultiTenancy is disabled.";
            }
        }
    }
}
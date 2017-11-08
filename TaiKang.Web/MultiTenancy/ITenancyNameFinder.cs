namespace TaiKang.Web.MultiTenancy
{
    public interface ITenancyNameFinder
    {
        string GetCurrentTenancyNameOrNull();
    }
}
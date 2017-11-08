namespace TaiKang.Emailing
{
    public interface IEmailTemplateProvider
    {
        string GetDefaultTemplate(int? tenantId);
    }
}

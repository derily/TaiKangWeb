namespace TaiKang.Authorization
{
    /// <summary>
    /// Defines string constants for application's permission names.
    /// <see cref="AppAuthorizationProvider"/> for permission definitions.
    /// </summary>
    public static class AppPermissions
    {
        //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

        public const string Pages = "Pages";


        public const string Pages_TaiKang = "Pages.TaiKang";

        public const string Pages_TaiKang_CompanyIndroduce = "Pages_TaiKang_CompanyIndroduce";
        public const string Pages_TaiKang_CompanyIndroduce_Edit = "Pages_TaiKang_CompanyIndroduce_Edit";

        public const string Pages_TaiKang_BannerManager = "Pages_TaiKang_BannerManager";
        public const string Pages_TaiKang_BannerManager_Create = "Pages_TaiKang_BannerManager_Create";
        public const string Pages_TaiKang_BannerManager_Edit = "Pages_TaiKang_BannerManager_Edit";
        public const string Pages_TaiKang_BannerManager_Delete = "Pages_TaiKang_BannerManager_Delete";

        public const string Pages_TaiKang_JobChance = "Pages_TaiKang_JobChance";
        public const string Pages_TaiKang_JobChance_Create = "Pages_TaiKang_JobChance_Create";
        public const string Pages_TaiKang_JobChance_Edit = "Pages_TaiKang_JobChance_Edit";
        public const string Pages_TaiKang_JobChance_Delete = "Pages_TaiKang_JobChance_Delete";

        public const string Pages_TaiKang_Contents = "Pages_TaiKang_Contents";
        public const string Pages_TaiKang_Contents_Create = "Pages_TaiKang_Contents_Create";
        public const string Pages_TaiKang_Contents_Edit = "Pages_TaiKang_Contents_Edit";
        public const string Pages_TaiKang_Contents_Delete = "Pages_TaiKang_Contents_Delete";

        public const string Pages_TaiKang_Products = "Pages_TaiKang_Products";
        public const string Pages_TaiKang_Products_Create = "Pages_TaiKang_Products_Create";
        public const string Pages_TaiKang_Products_Edit = "Pages_TaiKang_Products_Edit";
        public const string Pages_TaiKang_Products_Delete = "Pages_TaiKang_Products_Delete";


        public const string Pages_Administration = "Pages.Administration";

        public const string Pages_Administration_Roles = "Pages.Administration.Roles";
        public const string Pages_Administration_Roles_Create = "Pages.Administration.Roles.Create";
        public const string Pages_Administration_Roles_Edit = "Pages.Administration.Roles.Edit";
        public const string Pages_Administration_Roles_Delete = "Pages.Administration.Roles.Delete";

        public const string Pages_Administration_Users = "Pages.Administration.Users";
        public const string Pages_Administration_Users_Create = "Pages.Administration.Users.Create";
        public const string Pages_Administration_Users_Edit = "Pages.Administration.Users.Edit";
        public const string Pages_Administration_Users_Delete = "Pages.Administration.Users.Delete";
        public const string Pages_Administration_Users_ChangePermissions = "Pages.Administration.Users.ChangePermissions";
        public const string Pages_Administration_Users_Impersonation = "Pages.Administration.Users.Impersonation";

        public const string Pages_Administration_Languages = "Pages.Administration.Languages";
        public const string Pages_Administration_Languages_Create = "Pages.Administration.Languages.Create";
        public const string Pages_Administration_Languages_Edit = "Pages.Administration.Languages.Edit";
        public const string Pages_Administration_Languages_Delete = "Pages.Administration.Languages.Delete";
        public const string Pages_Administration_Languages_ChangeTexts = "Pages.Administration.Languages.ChangeTexts";

        public const string Pages_Administration_AuditLogs = "Pages.Administration.AuditLogs";

        public const string Pages_Administration_OrganizationUnits = "Pages.Administration.OrganizationUnits";
        public const string Pages_Administration_OrganizationUnits_ManageOrganizationTree = "Pages.Administration.OrganizationUnits.ManageOrganizationTree";
        public const string Pages_Administration_OrganizationUnits_ManageMembers = "Pages.Administration.OrganizationUnits.ManageMembers";

        public const string Pages_Administration_HangfireDashboard = "Pages.Administration.HangfireDashboard";

        //TENANT-SPECIFIC PERMISSIONS

        public const string Pages_Tenant_Dashboard = "Pages.Tenant.Dashboard";

        public const string Pages_Administration_Tenant_Settings = "Pages.Administration.Tenant.Settings";
        
        //HOST-SPECIFIC PERMISSIONS

        public const string Pages_Editions = "Pages.Editions";
        public const string Pages_Editions_Create = "Pages.Editions.Create";
        public const string Pages_Editions_Edit = "Pages.Editions.Edit";
        public const string Pages_Editions_Delete = "Pages.Editions.Delete";

        public const string Pages_Tenants = "Pages.Tenants";
        public const string Pages_Tenants_Create = "Pages.Tenants.Create";
        public const string Pages_Tenants_Edit = "Pages.Tenants.Edit";
        public const string Pages_Tenants_ChangeFeatures = "Pages.Tenants.ChangeFeatures";
        public const string Pages_Tenants_Delete = "Pages.Tenants.Delete";
        public const string Pages_Tenants_Impersonation = "Pages.Tenants.Impersonation";

        public const string Pages_Administration_Host_Maintenance = "Pages.Administration.Host.Maintenance";
        public const string Pages_Administration_Host_Settings = "Pages.Administration.Host.Settings";
    }
}
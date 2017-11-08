using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using TaiKang.Authorization.Users;
using TaiKang.MultiTenancy;

namespace TaiKang.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}

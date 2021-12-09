using Abp.MultiTenancy;
using TreinamentoJazzRaphael.Authorization.Users;

namespace TreinamentoJazzRaphael.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
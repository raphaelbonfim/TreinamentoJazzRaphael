using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using TreinamentoJazzRaphael.Authorization.Users;
using TreinamentoJazzRaphael.MultiTenancy;
using TreinamentoJazzRaphael.Users;
using Microsoft.AspNet.Identity;

namespace TreinamentoJazzRaphael
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class TreinamentoJazzRaphaelAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected TreinamentoJazzRaphaelAppServiceBase()
        {
            LocalizationSourceName = TreinamentoJazzRaphaelConsts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
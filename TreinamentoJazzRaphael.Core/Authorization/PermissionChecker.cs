using Abp.Authorization;
using TreinamentoJazzRaphael.Authorization.Roles;
using TreinamentoJazzRaphael.Authorization.Users;

namespace TreinamentoJazzRaphael.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

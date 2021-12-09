using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TreinamentoJazzRaphael.Roles.Dto;
using TreinamentoJazzRaphael.Users.Dto;

namespace TreinamentoJazzRaphael.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
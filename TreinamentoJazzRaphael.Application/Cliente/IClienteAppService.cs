using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoJazzRaphael.Cliente.Dto;

namespace TreinamentoJazzRaphael.Cliente
{
    public interface IClienteAppService: IApplicationService
    {
        void CreateCliente(CreateClienteDto input);
    }
}

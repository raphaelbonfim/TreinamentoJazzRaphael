using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoJazzRaphael.ValueObjects;

namespace TreinamentoJazzRaphael.Cliente.Dto
{
   
    public class CreateClienteDto
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string CPF { get; set; }

        [Required]
        public Endereco Endereco { get; set; }

    }
}

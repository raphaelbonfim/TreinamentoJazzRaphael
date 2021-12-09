using Abp.Domain.Entities.Auditing;
using TreinamentoJazzRaphael.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class Cliente : FullAuditedEntity
    {
        public Cliente( string nome, string cPF, Endereco endereco)
        {
            ClienteGuid = Guid.NewGuid();          
            Nome = nome;
            CPF = cPF;
            Endereco = endereco;
        }        
        
        public Guid ClienteGuid { get;}

        [StringLength(255)]
        public string Nome { get; set; }

        [StringLength(255)]
        public string CPF { get; set; }

        public Endereco Endereco { get; set; }

    }


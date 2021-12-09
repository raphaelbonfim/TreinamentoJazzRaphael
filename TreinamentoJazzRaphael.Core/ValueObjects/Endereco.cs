using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoJazzRaphael.ValueObjects
{
    public class Endereco
    {
        public Endereco(string rua, int numero, string bairro, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }

        [StringLength(255)]
        public string Rua { get; set; }

        public int Numero { get; set; }

        [StringLength(255)]
        public string Bairro { get; set; }

        [StringLength(255)]
        public string Cidade { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Contrato
{
    public class PessoaRequest
    {
        [Required]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereço { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Telefone { get; set; }
    }
}

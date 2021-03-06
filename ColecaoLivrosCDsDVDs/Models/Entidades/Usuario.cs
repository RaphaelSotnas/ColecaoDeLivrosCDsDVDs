using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]

        public string Login { get; set; }

        [Required]

        public string Senha { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereço { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        public int IdLivro { get; set; }

        public int IdCd { get; set; }

        public int IdDvd { get; set; }
    }
}

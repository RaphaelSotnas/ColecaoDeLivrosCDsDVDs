using ColecaoLivrosCDsDVDs.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Models.Entidades
{
    public class Livro
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Genero Genero { get; set; }

        public string Autor { get; set; }
    }
}

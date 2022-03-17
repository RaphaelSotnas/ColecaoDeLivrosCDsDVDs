using ColecaoLivrosCDsDVDs.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Contrato
{
    public class LivroRequest
    {
        public string Nome { get; set; }

        public Genero Genero { get; set; }

        public string Autor { get; set; }

        public Status Status { get; set; }
    }
}

using ColecaoLivrosCDsDVDs.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Models.Contrato
{
    public class DvdRequest
    {
        public string Nome { get; set; }

        public Genero Genero { get; set; }

        public Status Status { get; set; }
    }
}

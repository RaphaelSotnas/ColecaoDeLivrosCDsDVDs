using ColecaoLivrosCDsDVDs.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Contrato
{
    public class CdRequest
    {
        public string Nome { get; set; }

        public string Cantor { get; set; }

        public GeneroMusical GeneroMusical { get; set; }

        public Status Status { get; set; }
    }
}

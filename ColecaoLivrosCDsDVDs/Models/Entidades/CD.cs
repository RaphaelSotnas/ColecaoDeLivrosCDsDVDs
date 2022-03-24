using ColecaoLivrosCDsDVDs.Contrato;
using ColecaoLivrosCDsDVDs.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Models.Entidades
{
    public class CD
    {
        private CD()
        {

        }

        public CD(CdRequest CdRequest)
        {
            Nome = CdRequest.Nome;
            GeneroMusical = CdRequest.GeneroMusical;
            Status = CdRequest.Status;
            Cantor = CdRequest.Cantor;
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cantor { get; set; }

        public GeneroMusical GeneroMusical { get; set; }

        public Status Status { get; set; }

    }
}

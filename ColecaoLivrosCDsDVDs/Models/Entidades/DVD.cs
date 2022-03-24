using ColecaoLivrosCDsDVDs.Enum;
using ColecaoLivrosCDsDVDs.Models.Contrato;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Models.Entidades
{
    public class DVD
    {
        private DVD()
        {

        }

        public DVD(DvdRequest dvdRequest)
        {
            Nome = dvdRequest.Nome;
            Genero = dvdRequest.Genero;
            Status = dvdRequest.Status;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public Genero Genero { get; set; }

        public Status Status { get; set; }

    }
}

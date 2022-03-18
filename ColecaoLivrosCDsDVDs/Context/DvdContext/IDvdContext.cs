using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.DvdContext
{
    public interface IDvdContext
    {
        void CadastrarDvd(DVD cd);

        DVD BuscarDvdPorId(int id);

        public List<DVD> ListarDvds();

        void AtualizarDvd(DVD dvd);

        void ExcluirDvd(int id);
    }
}

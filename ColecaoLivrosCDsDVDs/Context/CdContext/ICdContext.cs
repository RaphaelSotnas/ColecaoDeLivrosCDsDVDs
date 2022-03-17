using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.CdContext
{
    public interface ICdContext
    {
        void CadastrarCd(CD cd);

        CD BuscarCdPorId(int id);

        public List<CD> ListarCds();

        void AtualizarCd(CD cd);

        void ExcluirCd(int id);
    }
}

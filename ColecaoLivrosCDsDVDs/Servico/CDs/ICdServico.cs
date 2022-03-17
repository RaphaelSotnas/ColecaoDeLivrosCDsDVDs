using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.CDs
{
    public interface ICdServico
    {
        void CadastrarCd(CD cd);

        CD BuscarCdPorId(int id);

        public List<CD> ListarCds();

        void AtualizarCd(CD cd);

        void ExcluirCd(int id);
    }
}

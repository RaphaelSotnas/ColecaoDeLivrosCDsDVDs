using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Emprestimo
{
    public interface IEmprestimoServico
    {
        public void EfetuarEmprestimoLivro(int idLivro);

        public void EfetuarEmprestimoCd(int idCd);

        public void EfetuarEmprestimoDvd(int idDvd);
    }
}

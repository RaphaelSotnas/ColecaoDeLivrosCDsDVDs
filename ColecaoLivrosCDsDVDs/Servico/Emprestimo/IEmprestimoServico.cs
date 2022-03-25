using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.Emprestimo
{
    public interface IEmprestimoServico
    {
        public bool EfetuarEmprestimoLivro(int idLivro);

        public bool EfetuarEmprestimoCd(int idCd);

        public bool EfetuarEmprestimoDvd(int idDvd);
    }
}

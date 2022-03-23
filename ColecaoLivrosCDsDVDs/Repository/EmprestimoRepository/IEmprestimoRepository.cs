using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository
{
    public interface IEmprestimoRepository
    {
        void EfetuarEmprestimoLivro(int idLivro);
        void EfetuarEmprestimoCd(int idCd);
        void EfetuarEmprestimoDvd(int idDvd);
    }
}

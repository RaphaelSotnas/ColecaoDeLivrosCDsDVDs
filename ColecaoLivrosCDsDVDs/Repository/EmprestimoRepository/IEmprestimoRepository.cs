using ColecaoLivrosCDsDVDs.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Repository.EmprestimoRepository
{
    public interface IEmprestimoRepository
    {
        bool EfetuarEmprestimoLivro(int idLivro);
        bool EfetuarEmprestimoCd(int idCd);
        bool EfetuarEmprestimoDvd(int idDvd);
    }
}

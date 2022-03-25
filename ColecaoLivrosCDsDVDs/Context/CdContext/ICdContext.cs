using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Context.CdContext
{
    public interface ICdContext : IGenericoRepository<CD>
    {
        bool EfetuarEmprestimoCd(int idCd);
    }
}

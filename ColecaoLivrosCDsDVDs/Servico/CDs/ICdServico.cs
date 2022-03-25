using ColecaoLivrosCDsDVDs.Models.Entidades;
using ColecaoLivrosCDsDVDs.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Servico.CDs
{
    public interface ICdServico : IGenericoRepository<CD>
    {
        bool EfetuarEmprestimoCd(int idCd);
    }
}
